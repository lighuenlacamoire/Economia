using System;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;
using log4net;
using System.Net.Security;
using System.Globalization;
using System.ServiceModel.Channels;
using System.Net;
using System.ServiceModel;
using System.Web.Script.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Serialization;
using System.Text;
using ESIDIFLimitativa.Tools;
using ESIDIFLimitativa.Soap;

namespace ESIDIFLimitativa.Negocio
{
    public class HelperRecursos
    {
        private service.consultarLimitativaCreditoServiceClient _service = new service.consultarLimitativaCreditoServiceClient();
        private GestionService.GestionServiceSoapClient _gestionClavesService = new GestionService.GestionServiceSoapClient();

        private static string ServiceLogName = "Limitativa";

        private static readonly ILog log = LogManager.GetLogger(ServiceLogName);

        public HelperRecursos()
        {

        }

        //  public ESIDIFLimitativa.service.imputacionCreditoConsulta consultarLimitativaCredito(ESIDIFLimitativa.service.consultarLimitativaCreditoRequest request)  
        public Models.imputacionCreditoConsulta consultarLimitativaCredito(Models.consultarLimitativaCreditoRequest request)
        {
            Models.imputacionCreditoConsulta ret = new Models.imputacionCreditoConsulta();

            log.Info(ServiceLogName+" - Ingreso");
            var b = _service.Endpoint.Binding as CustomBinding;

            log.Debug(ServiceLogName+" - Seteando variables de contexto.");
            string usuarioProxy = ConfigurationManager.AppSettings["CPA_Proxy_Usuario"];
            string passwdProxy = ConfigurationManager.AppSettings["CPA_Proxy_Passwd"];
            string urlProxy = ConfigurationManager.AppSettings["CPA_Proxy_URL"];
            string domainProxy = ConfigurationManager.AppSettings["CPA_Proxy_Dominio"];
            string digitalMark = ConfigurationManager.AppSettings["CERTI_DIGITAL_MARK"];

            string usuarioWS = ConfigurationManager.AppSettings["WS_Usuario"];

            #region Consulta Servicio Gestion Claves
            string passwdWS = string.Empty;
            bool gestionClavesSuccess = true;
            string gestionClavesMessage = string.Empty;

            try
            {
                log.Info("Inicio Servicio Gestion Claves");
                string gestionClavesEndpoint = ConfigurationManager.AppSettings["GClaves_Endpoint"];
                _gestionClavesService.Endpoint.Address = new EndpointAddress(gestionClavesEndpoint);

                string gcUser = ConfigurationManager.AppSettings["GCLaves_USU"];
                string gcPass = ConfigurationManager.AppSettings["GCLaves_PSW"];

                string key = ConfigurationManager.AppSettings["GClaves_EsidifPass"];

                log.Info("Invocando al metodo ConsultarKey");
                string result = _gestionClavesService.ConsultarKey(gcUser, gcPass, key);

                if (!string.IsNullOrEmpty(result) && result.Length > 0)
                {
                    log.Info("Invocacion a Gestion Claves Correcta");
                    passwdWS = result;
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

            log.Debug(ServiceLogName+" - Seteando PROXY.");
            HttpsTransportBindingElement httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.ProxyAddress = new Uri(urlProxy);
            httpsTransport.UseDefaultWebProxy = false;
            httpsTransport.BypassProxyOnLocal = false;
            httpsTransport.MaxReceivedMessageSize = 2147483647;


            if (ConfigurationManager.AppSettings["CERTI_IGNORA_ERROR"] == "true")
            {
                log.Debug(ServiceLogName+" - IGNORA_ERROR_CERTI = true.");
                System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;
            }


            if (ConfigurationManager.AppSettings["CPA_Proxy_Credenciales"] == "true")
            {
                log.Debug(ServiceLogName+" - CPA_Proxy_Credenciales = true.");
                httpsTransport.ProxyAuthenticationScheme = AuthenticationSchemes.Basic;
                _service.ClientCredentials.UserName.UserName = usuarioProxy;
                _service.ClientCredentials.UserName.Password = passwdProxy;
            }
            else
            {
                log.Debug(ServiceLogName+" - CPA_Proxy_Credenciales = false.");
                httpsTransport.ProxyAuthenticationScheme = AuthenticationSchemes.Ntlm; 
            }

            b.Elements.Add(httpsTransport);


            if (ConfigurationManager.AppSettings["CERTI_APLICA"] == "true")
            {
                log.Debug(ServiceLogName+" - Cargando certificado X509.");
                _service.ClientCredentials.ClientCertificate.Certificate = GetClientCertificate(digitalMark);
                log.Debug(ServiceLogName+" - Certificado X509 cargado exitosamente.");
            }

            using (var scope = new OperationContextScope(_service.InnerChannel))
            {
                try
                {

                    log.Debug(ServiceLogName+" - Creando Bean");
                    var paramMecom = service.imputacionCreditoConsulta.Create();
                    
                    log.Debug(ServiceLogName+" - Mapeando a objeto MECON.");
                    Funciones.CopyPropertiesTo(request.imputacionPresupuestariaCreditoIndicativa, paramMecom);
                    
                    log.Debug(ServiceLogName+" - Armando header de autenticacion");
                    OperationContext.Current.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

                    _service.Endpoint.Address = new EndpointAddress(ConfigurationManager.AppSettings["WS_Endpoint"]);

                    var response = _service.consultarLimitativaCredito(paramMecom);

                    Funciones.CopyPropertiesTo(response, ret);

                    return ret;
                }
                catch (Exception ex)
                {
                    log.Error(ServiceLogName+" - Error en la ejecucion : " + ex.Message);
                    throw ex;
                }
            };
        }
 

        public bool RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // DANGEROUS!  completely disable SSL validation if the test server has a bad Cert / bad Cert chain
            log.Debug("RemoteCertificateValidationCallback - Entro: Issuer" + certificate.Issuer);

            return true;
        }

        private static X509Certificate2 GetClientCertificate(string digitalMark)
        {
            X509Store userCaStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            try
            {
                userCaStore.Open(OpenFlags.ReadOnly);
                X509Certificate2Collection certificatesInStore = userCaStore.Certificates;
                X509Certificate2Collection findResult = certificatesInStore.Find(X509FindType.FindByThumbprint, digitalMark, true);
                X509Certificate2 clientCertificate = null;
                if (findResult.Count == 1)
                {
                    clientCertificate = findResult[0];
                }
                else
                {
                    throw new Exception("No se encontro el certificado");
                }
                return clientCertificate;
            }
            catch
            {
                throw;
            }
            finally
            {
                userCaStore.Close();
            }
        }

        private X509Certificate2 GetCertificateByThumbprint(string certificateThumbPrint, StoreLocation certificateStoreLocation)
        {
            X509Certificate2 certificate = null;

            X509Store certificateStore = new X509Store(certificateStoreLocation);
            certificateStore.Open(OpenFlags.ReadOnly);


            X509Certificate2Collection certCollection = certificateStore.Certificates;
            foreach (X509Certificate2 cert in certCollection)
            {
                if (cert.Thumbprint != null && cert.Thumbprint.Equals(certificateThumbPrint, StringComparison.OrdinalIgnoreCase))
                {
                    certificate = cert;
                    break;
                }
            }

            if (certificate == null)
            {
                log.ErrorFormat(CultureInfo.InvariantCulture, "El certificado con huella digital {0} no fue encontrado.", certificateThumbPrint);
            }

            return certificate;
        }

        public Exception CapturarSoapError(Exception ex)
        {
            try
            {
                FaultException faultException = ex as FaultException;
                MessageFault msgFault = faultException != null ? faultException.CreateMessageFault() : null;
                XmlElement elm = msgFault != null ? msgFault.GetDetail<XmlElement>() : null;

                if (elm != null)
                {
                    var errorCodeTag = elm.GetElementsByTagName("ErrorCode");
                    var errorDescripcionTag = elm.GetElementsByTagName("ErrorDescription");

                    if (errorCodeTag != null && errorCodeTag.Count > 0 && errorDescripcionTag != null && errorDescripcionTag.Count > 0)
                    {
                        ex = new Exception(errorCodeTag[0].InnerText + " " + errorDescripcionTag[0].InnerText);
                    }
                }
            }
            catch
            {

            }
            return ex;
        }
    }
}