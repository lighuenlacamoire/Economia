using ESIDIF.Tools;
using ESIDIFCRGOV.Extensions;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ESIDIFCRGOV.Business
{
    public class Sources
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CRGOVService));

        public Sources()
        {

        }
        public Models.crgOvResponse generarCrgOvWeb(Models.crgOvRequest data)
        {
            log.Info("GenerarCrgOv - Ingreso");

            log.Debug("GenerarCrgOv - Seteando variables de contexto.");

            string usuarioProxy = Settings.GetAppSettings("Settings:Proxy:User");
            string passwdProxy = Settings.GetAppSettings("Settings:Proxy:Password");
            string urlProxy = Settings.GetAppSettings("Settings:Proxy:Url");
            string domainProxy = Settings.GetAppSettings("Settings:Proxy:Domain");

            string usuarioWS = Settings.GetAppSettings("Settings:Service:User");
            string passwdWS = Settings.GetAppSettings("Settings:Service:Password");

            string WSAction = Settings.GetAppSettings("Settings:Service:Action");
            string WSEndpoint = Settings.GetAppSettings("Settings:Service:Endpoint");

            log.Debug("GenerarCrgOv - Seteando PROXY.");
            WebProxy proxy = Functions.CrearProxy();

            log.Debug("GenerarCrgOv - Cargando certificado X509.");
            NetworkCredential credential = new NetworkCredential(usuarioWS, passwdWS);
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri(WSEndpoint), "NTLM", credential);

            log.Debug("GenerarCrgOv - IGNORA_ERROR_CERTI = true.");
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;

            log.Debug("GenerarCrgOv - Certificado X509 cargado exitosamente.");

            log.Debug("GenerarCrgOv - Creando Bean");
            var envelope = new Soap.Envelope();
            envelope.Header = new Soap.Header("UsernameToken-1", usuarioWS, passwdWS, WSEndpoint, WSAction);
            envelope.Body = new Soap.Body(data);

            System.Xml.Serialization.XmlSerializerNamespaces xmlnsSoap = new System.Xml.Serialization.XmlSerializerNamespaces();
            xmlnsSoap.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            xmlnsSoap.Add("com", "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg");
            xmlnsSoap.Add("com1", "https://ws-si.mecon.gov.ar/ws/comprobantesCrg");
            xmlnsSoap.Add("com2", "https://ws-si.mecon.gov.ar/ws/comprobantes");
            xmlnsSoap.Add("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            xmlnsSoap.Add("wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
            xmlnsSoap.Add("wsa", "http://www.w3.org/2005/08/addressing");

            log.Debug("GenerarCrgOv - Mapeando a objeto XML.");
            string result = Functions.SerializeObjectToString(envelope, xmlnsSoap);

            log.Debug("GenerarCrgOv - Armando header de autenticacion");
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
            request.ClientCertificates.Add(Functions.GetClientCertificate());

            try
            {
                using (Stream stm = request.GetRequestStream())
                {
                    using (StreamWriter stmw = new StreamWriter(stm))
                    {
                        stmw.Write(result);
                    }
                }

                log.Info("Consulta Servicio - ESIDIF : " + Environment.NewLine + result);
                WebResponse response = request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                }

                var resp = Functions.DeserializeXMLFileToObject<Models.crgOvResponse>(result);

                return resp;

            }
            catch (WebException exp)
            {
                log.Error("GenerarCrgOv - Error en la ejecucion : " + exp.Message);

                using (StreamReader sr = new StreamReader(exp.Response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }

                throw new Exception(result);
            }
        }

        public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
