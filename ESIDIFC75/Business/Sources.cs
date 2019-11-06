using ESIDIFCommon.GestionService;
using ESIDIFCommon.Models.Xml;
using ESIDIFCommon.Tools;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Web;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ESIDIFC75.Business
{
    public class Sources
    {
        private GestionServiceSoapClient _gestionService = new GestionServiceSoapClient();

        public static string ServiceLogName = "C75";

        private static readonly ILog log = LogManager.GetLogger(ServiceLogName);

        public Sources()
        {

        }
        
        public Models.generarInformeDeGastosResponse generarInformeDeGastosWeb(Models.generarInformeDeGastos data)
        {
            #region borrado de espacios vacios en los string
            try
            {
                //Limpieza codigo strings
                Functions.CheckStringFields(ref data);
            }
            catch (Exception ex)
            {
                log.Info(ex.Message);
            }
            #endregion

            log.Info(ServiceLogName + " - Ingreso");

            #region Configuracion de variables de entorno
            log.Debug(ServiceLogName + " - Seteando variables de entorno.");
            string digitalMark = ConfigurationManager.AppSettings["CERTI_DIGITAL_MARK"];

            string usuarioWS = ConfigurationManager.AppSettings["WS_Usuario"];

            string WSAction = ConfigurationManager.AppSettings["WS_Action"];
            string WSEndpoint = ConfigurationManager.AppSettings["WS_Endpoint"];
            #endregion

            #region Consulta Servicio Gestion Claves
            //string passwdWS = ConfigurationManager.AppSettings["WS_Passwd"];
            string passwdWS = string.Empty;
            bool gestionClavesSuccess = true;
            string gestionClavesMessage = string.Empty;

            try
            {
                log.Info("Inicio Servicio Gestion Claves");
                string gestionClavesEndpoint = ConfigurationManager.AppSettings["GClaves_Endpoint"];
                _gestionService.Endpoint.Address = new EndpointAddress(gestionClavesEndpoint);

                string gcUser = ConfigurationManager.AppSettings["GCLaves_USU"];
                string gcPass = ConfigurationManager.AppSettings["GCLaves_PSW"];

                string key = ConfigurationManager.AppSettings["GClaves_EsidifPass"];

                log.Info("Invocando al metodo ConsultarKey");
                string resultGC = _gestionService.ConsultarKey(gcUser, gcPass, key);

                if (!string.IsNullOrEmpty(resultGC) && resultGC.Length > 0)
                {
                    log.Info("Invocacion a Gestion Claves Correcta");
                    passwdWS = resultGC;
                }
                else
                {
                    throw new Exception("El valor devuelto esta vacio");
                }

            }
            catch (Exception ex)
            {
                gestionClavesSuccess = false;
                gestionClavesMessage = ex.Message;
                log.Info("Fallo la invocacion a Gestion Claves: " + ex.Message);
            }

            if (!gestionClavesSuccess)
            {
                throw new Exception(gestionClavesMessage);
            }
            #endregion

            #region Configuracion del Proxy
            log.Debug(ServiceLogName + " - Seteando PROXY.");
            string usuarioProxy = ConfigurationManager.AppSettings["CPA_Proxy_Usuario"];
            string passwdProxy = ConfigurationManager.AppSettings["CPA_Proxy_Passwd"];
            string urlProxy = ConfigurationManager.AppSettings["CPA_Proxy_URL"];
            string domainProxy = ConfigurationManager.AppSettings["CPA_Proxy_Dominio"];
            WebProxy proxy = Functions.CreateProxy(usuarioProxy, passwdProxy, urlProxy, domainProxy);
            #endregion

            #region Configuracion de las Credenciales/Certificado X509
            log.Debug(ServiceLogName + " - Cargando certificado X509.");
            NetworkCredential credential = new NetworkCredential(usuarioWS, passwdWS);
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri(WSEndpoint), "NTLM", credential);
            #endregion

            if (ConfigurationManager.AppSettings["CERTI_IGNORA_ERROR"] == "true")
            {
                log.Debug(ServiceLogName + " - IGNORA_ERROR_CERTI = true.");
                ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;
            }
            log.Debug(ServiceLogName + " - Certificado X509 cargado exitosamente.");

            #region Creando el Objeto para enviar en el Servicio
            log.Debug(ServiceLogName + " - Creando Bean");
            var envelope = new Envelope();
            envelope.Header = new Header("UsernameToken-1", usuarioWS, passwdWS, WSEndpoint, WSAction);
            envelope.Body = new XmlAnything<IBody>(data);

            XmlSerializerNamespaces xmlnsSoap = new XmlSerializerNamespaces();
            xmlnsSoap.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            xmlnsSoap.Add("inf", "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg");
            xmlnsSoap.Add("inf1", "https://ws-si.mecon.gov.ar/ws/informeDeGastos");
            xmlnsSoap.Add("com", "https://ws-si.mecon.gov.ar/ws/comprobantes");
            xmlnsSoap.Add("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            xmlnsSoap.Add("wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
            xmlnsSoap.Add("wsa", "http://www.w3.org/2005/08/addressing");

            log.Debug(ServiceLogName + " - Mapeando a objeto XML.");
            string msgRequest = Functions.SerializeObjectToString(envelope, xmlnsSoap);
            string msgResponse = string.Empty;
            #endregion

            #region Creando el servicio
            log.Debug(ServiceLogName + " - Armando header de autenticacion");
            HttpWebRequest request = WebRequest.Create(WSEndpoint) as HttpWebRequest;
            request.Headers.Add("SOAPAction", WSAction);
            request.ContentType = "text/xml;charset=\"utf-8\"";
            request.Accept = "text/xml";
            request.Method = WebRequestMethods.Http.Post;
            request.KeepAlive = true;
            request.PreAuthenticate = true;
            request.AuthenticationLevel = AuthenticationLevel.MutualAuthRequested;
            request.Proxy = proxy;
            request.Credentials = credentialCache;
            request.ClientCertificates.Add(Functions.GetClientCertificate(digitalMark));
            #endregion

            #region Generando la solicitud
            using (Stream stm = request.GetRequestStream())
            {
                using (StreamWriter stmw = new StreamWriter(stm))
                {
                    stmw.Write(msgRequest);
                }
            }
            log.Info("Consulta Servicio - ESIDIF : " + Environment.NewLine + Functions.ParseXml(msgRequest));
            WebResponse response = request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                msgResponse = reader.ReadToEnd();
            }
            #endregion

            #region Deserealizando la respuesta
            log.Info("Respuesta ESIDIF - Servicio : " + Environment.NewLine + Functions.ParseXml(msgResponse));
            var resp = Functions.DeserializeXMLString<Models.generarInformeDeGastosResponse>(msgResponse);
            #endregion

            return resp;

        }

        public SoapException HandleError(Exception ex)
        {
            SoapError error = Functions.SoapErrorFromException(ex);

            log.Error("Error en la ejecucion : " + error.FaultDetail);

            return new SoapException(error.FaultDetail, SoapException.ServerFaultCode, error.FaultReason, error.FaultNode);
        }
        public SoapException HandleError(WebException ex)
        {
            SoapError error = Functions.SoapErrorFromWebException(ex);

            log.Error("Error en la ejecucion : " + error.FaultDetail);

            log.Error("Respuesta ESIDIF - Servicio: " + Environment.NewLine + Functions.ParseXml(error.FaultResponse));

            return new SoapException(error.FaultDetail, SoapException.ServerFaultCode, error.FaultReason, error.FaultNode);
        }

        public bool RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // DANGEROUS!  completely disable SSL validation if the test server has a bad Cert / bad Cert chain
            log.Debug("RemoteCertificateValidationCallback - Entro: Issuer" + certificate.Issuer);

            return true;
        }

    }
}