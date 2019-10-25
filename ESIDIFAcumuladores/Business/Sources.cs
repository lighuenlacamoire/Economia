
using ESIDIFAcumuladores.Extensions;
using ESIDIFCommon.Models.Xml;
using ESIDIFCommon.Tools;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace ESIDIFAcumuladores.Business
{
    public class Sources
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(AcumuladoresService));

        private static string ServiceLogName = "Acumuladores";

        private static System.Xml.XmlDocument doc = new System.Xml.XmlDocument();

        private static System.Xml.XmlNode node = doc.CreateNode(XmlNodeType.Element, "Detail", "");

        private static SoapError soapError = new SoapError();
        private static string result = "";
        private static string faultFactor = "Economia";
        private static string faultDetail = "Error inesperado revise el log para mayor detalle";

        public Sources()
        {

        }
        public Models.acumuladoresCreditoConsulta acumuladoresCreditoIndicativaWeb(Models.imputacionCreditoConsulta data)
        {
            try
            {
                //Limpieza codigo strings
                Functions.CheckStringFields(ref data);
            }
            catch (Exception ex)
            {
                log.Info(ex.Message);
            }

            log.Info(ServiceLogName + " - Ingreso");

            log.Debug(ServiceLogName + " - Seteando variables de contexto.");

            string usuarioProxy = Settings.GetAppSettings("Settings:Proxy:User");
            string passwdProxy = Settings.GetAppSettings("Settings:Proxy:Password");
            string urlProxy = Settings.GetAppSettings("Settings:Proxy:Url");
            string domainProxy = Settings.GetAppSettings("Settings:Proxy:Domain");

            string usuarioWS = Settings.GetAppSettings("Settings:Service:User");
            string passwdWS = Settings.GetAppSettings("Settings:Service:Password");

            string digitalMark = Settings.GetAppSettings("Settings:Credential:DigitalMark");

            string WSAction = Settings.GetAppSettings("Settings:Service:Action");
            string WSEndpoint = Settings.GetAppSettings("Settings:Service:Endpoint");

            #region Consulta Servicio Gestion Claves
            //string passwdWS = string.Empty;
            //bool gestionClavesSuccess = true;
            //string gestionClavesMessage = string.Empty;

            //try
            //{
            //    log.Info("Inicio Servicio Gestion Claves");
            //    string gestionClavesEndpoint = ConfigurationManager.AppSettings["GClaves_Endpoint"];
            //    _gestionService.Endpoint.Address = new EndpointAddress(gestionClavesEndpoint);

            //    string gcUser = ConfigurationManager.AppSettings["GCLaves_USU"];
            //    string gcPass = ConfigurationManager.AppSettings["GCLaves_PSW"];

            //    string key = ConfigurationManager.AppSettings["GClaves_EsidifPass"];

            //    log.Info("Invocando al metodo ConsultarKey");
            //    string resultGC = _gestionService.ConsultarKey(gcUser, gcPass, key);

            //    if (!string.IsNullOrEmpty(resultGC) && resultGC.Length > 0)
            //    {
            //        log.Info("Invocacion a Gestion Claves Correcta");
            //        passwdWS = resultGC;
            //    }
            //    else
            //    {
            //        throw new Exception("El valor devuelto esta vacio");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    gestionClavesSuccess = false;
            //    gestionClavesMessage = ex.Message;
            //    log.Info("Fallo la invocacion a Gestion Claves: " + ex.Message);
            //}

            //if (!gestionClavesSuccess)
            //{
            //    throw new Exception(gestionClavesMessage);
            //}
            #endregion

            log.Debug(ServiceLogName + " - Seteando PROXY.");
            WebProxy proxy = Functions.CreateProxy(usuarioProxy, passwdProxy, urlProxy, domainProxy);

            log.Debug(ServiceLogName + " - Cargando certificado X509.");
            NetworkCredential credential = new NetworkCredential(usuarioWS, passwdWS);
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri(WSEndpoint), "NTLM", credential);

            log.Debug(ServiceLogName + " - IGNORA_ERROR_CERTI = true.");
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;

            log.Debug(ServiceLogName + " - Certificado X509 cargado exitosamente.");

            log.Debug(ServiceLogName + " - Creando Bean");
            var envelope = new Envelope();
            envelope.Header = new Header("UsernameToken-1", usuarioWS, passwdWS, WSEndpoint, WSAction);
            envelope.Body = new XmlAnything<IBody>(data);

            System.Xml.Serialization.XmlSerializerNamespaces xmlnsSoap = new System.Xml.Serialization.XmlSerializerNamespaces();
            xmlnsSoap.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            xmlnsSoap.Add("web", "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar");
            xmlnsSoap.Add("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            xmlnsSoap.Add("wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
            xmlnsSoap.Add("wsa", "http://www.w3.org/2005/08/addressing");

            log.Debug(ServiceLogName + " - Mapeando a objeto XML.");
            string msgRequest = Functions.SerializeObjectToString(envelope, xmlnsSoap);
            string msgResponse = string.Empty;

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

            log.Info("Respuesta ESIDIF - Servicio : " + Environment.NewLine + Functions.ParseXml(msgResponse));
            var resp = Functions.DeserializeXMLString<Models.acumuladoresCreditoConsulta>(msgResponse);

            return resp;


        }


        public FaultException manejoWebError(WebException exp)
        {
            string msgResponse = string.Empty;

            WebResponse response = exp.Response;
            faultDetail = exp.InnerException != null ? exp.InnerException.Message : exp.Message;

            log.Error("Error en la ejecucion : " + faultDetail);

            if (response != null)
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    msgResponse = sr.ReadToEnd();
                }
            }
            else
            {
                msgResponse = faultDetail;
            }

            log.Error("Respuesta ESIDIF - Servicio: " + Environment.NewLine + Functions.ParseXml(msgResponse));
            soapError = Functions.HandleWebException(msgResponse);

            if (soapError != null)
            {
                faultFactor = "Economia";
                faultDetail = soapError.ErrorCode + " " + soapError.ErrorDescription;
            }

            node.InnerText = faultDetail;

            //return new FaultException(faultDetail, SoapException.ServerFaultCode, faultFactor, node);
            return new FaultException(new FaultReason(faultDetail), new FaultCode(faultFactor), "");
        }

        public FaultException manejoError(Exception ex)
        {
            faultFactor = "Servicio";
            faultDetail = ex.InnerException != null ? ex.InnerException.Message : ex.Message;

            node.InnerText = faultDetail;
            return new FaultException(new FaultReason(faultDetail), new FaultCode(faultFactor), "");
        }

        public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
