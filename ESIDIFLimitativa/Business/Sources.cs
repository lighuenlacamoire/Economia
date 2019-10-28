using ESIDIFCommon.Models.Xml;
using ESIDIFCommon.Tools;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Services.Protocols;

namespace ESIDIFLimitativa.Business
{
    public class Sources
    {
        private service.consultarLimitativaCreditoServiceClient _service = new service.consultarLimitativaCreditoServiceClient();
        private GestionService.GestionServiceSoapClient _gestionClavesService = new GestionService.GestionServiceSoapClient();

        private static string ServiceLogName = "Limitativa";

        private static readonly ILog log = LogManager.GetLogger(ServiceLogName);

        public Sources()
        {

        }

        //  public ESIDIFLimitativa.service.imputacionCreditoConsulta consultarLimitativaCredito(ESIDIFLimitativa.service.consultarLimitativaCreditoRequest request)  
        public Models.imputacionCreditoConsulta consultarLimitativaCredito(Models.consultarLimitativaCreditoRequest request)
        {
            Models.imputacionCreditoConsulta ret = new Models.imputacionCreditoConsulta();

            log.Info(ServiceLogName + " - Ingreso");
            var b = _service.Endpoint.Binding as CustomBinding;

            log.Debug(ServiceLogName + " - Seteando variables de contexto.");
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

            log.Debug(ServiceLogName + " - Seteando PROXY.");
            HttpsTransportBindingElement httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.ProxyAddress = new Uri(urlProxy);
            httpsTransport.UseDefaultWebProxy = false;
            httpsTransport.BypassProxyOnLocal = false;
            httpsTransport.MaxReceivedMessageSize = 2147483647;


            if (ConfigurationManager.AppSettings["CERTI_IGNORA_ERROR"] == "true")
            {
                log.Debug(ServiceLogName + " - IGNORA_ERROR_CERTI = true.");
                System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;
            }


            if (ConfigurationManager.AppSettings["CPA_Proxy_Credenciales"] == "true")
            {
                log.Debug(ServiceLogName + " - CPA_Proxy_Credenciales = true.");
                httpsTransport.ProxyAuthenticationScheme = AuthenticationSchemes.Basic;
                _service.ClientCredentials.UserName.UserName = usuarioProxy;
                _service.ClientCredentials.UserName.Password = passwdProxy;
            }
            else
            {
                log.Debug(ServiceLogName + " - CPA_Proxy_Credenciales = false.");
                httpsTransport.ProxyAuthenticationScheme = AuthenticationSchemes.Ntlm;
            }

            b.Elements.Add(httpsTransport);


            if (ConfigurationManager.AppSettings["CERTI_APLICA"] == "true")
            {
                log.Debug(ServiceLogName + " - Cargando certificado X509.");
                _service.ClientCredentials.ClientCertificate.Certificate = Functions.GetClientCertificate(digitalMark);
                log.Debug(ServiceLogName + " - Certificado X509 cargado exitosamente.");
            }

            using (var scope = new OperationContextScope(_service.InnerChannel))
            {
                try
                {

                    log.Debug(ServiceLogName + " - Creando Bean");
                    var paramMecom = GenericClass<service.imputacionCreditoConsulta>.GenericMethod(); //service.imputacionCreditoConsulta.Create();

                    log.Debug(ServiceLogName + " - Mapeando a objeto MECON.");
                    Functions.CopyPropertiesTo(request.imputacionPresupuestariaCreditoIndicativa, paramMecom);

                    log.Debug(ServiceLogName + " - Armando header de autenticacion");
                    OperationContext.Current.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

                    _service.Endpoint.Address = new EndpointAddress(ConfigurationManager.AppSettings["WS_Endpoint"]);

                    var response = _service.consultarLimitativaCredito(paramMecom);

                    Functions.CopyPropertiesTo(response, ret);

                    return ret;
                }
                catch (Exception ex)
                {
                    log.Error(ServiceLogName + " - Error en la ejecucion : " + ex.Message);
                    throw ex;
                }
            };
        }

        public SoapException HandleError(Exception ex)
        {
            SoapError error = Functions.SoapErrorFromException(ex);
            
            ex = Functions.FindXmlErrorDetail(ex);

            if(ex != null)
            {
                log.Error("Error en la ejecucion : " + ex.Message);
                return new SoapException("Error", SoapException.ClientFaultCode, error.FaultDetail, ex);
            }
            else
            {
                log.Error("Error en la ejecucion : " + error.FaultDetail);
                return new SoapException(error.FaultDetail, SoapException.ServerFaultCode, error.FaultReason, error.FaultNode);
            }

        }
        public bool RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // DANGEROUS!  completely disable SSL validation if the test server has a bad Cert / bad Cert chain
            log.Debug("RemoteCertificateValidationCallback - Entro: Issuer" + certificate.Issuer);

            return true;
        }
        
    }
}