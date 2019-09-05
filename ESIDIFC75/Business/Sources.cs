using ESIDIF.Models;
using ESIDIF.Tools;
using ESIDIFC75.Extensions;
using log4net;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;

namespace ESIDIFC75.Business
{
    public class Sources
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(C75Service));

        public Sources()
        {

        }
        public Models.generarInformeDeGastosResponse generarInformeDeGastosPortTypeWeb(Models.generarInformeDeGastos data)
        {
            log.Info("GenerarInformeDeGastos - Ingreso");

            log.Debug("GenerarInformeDeGastos - Seteando variables de contexto.");
            //string usuarioProxy = ConfigurationManager.AppSettings["CPA_Proxy_Usuario"];
            //string passwdProxy = ConfigurationManager.AppSettings["CPA_Proxy_Passwd"];
            //string urlProxy = ConfigurationManager.AppSettings["CPA_Proxy_URL"];
            //string domainProxy = ConfigurationManager.AppSettings["CPA_Proxy_Dominio"];

            //string usuarioWS = ConfigurationManager.AppSettings["WS_Usuario"];
            //string passwdWS = ConfigurationManager.AppSettings["WS_Passwd"];

            string usuarioProxy = Settings.GetAppSettings("Settings:Proxy:User");
            string passwdProxy = Settings.GetAppSettings("Settings:Proxy:Password");
            string urlProxy = Settings.GetAppSettings("Settings:Proxy:Url");
            string domainProxy = Settings.GetAppSettings("Settings:Proxy:Domain");

            string usuarioWS = Settings.GetAppSettings("Settings:Service:User");
            string passwdWS = Settings.GetAppSettings("Settings:Service:Password");

            string WSAction = Settings.GetAppSettings("Settings:Service:Action");
            string WSEndpoint = Settings.GetAppSettings("Settings:Service:Endpoint");

            log.Debug("GenerarInformeDeGastos - Seteando PROXY.");
            WebProxy proxy = Functions.CrearProxy();

            log.Debug("GenerarInformeDeGastos - Cargando certificado X509.");
            NetworkCredential credential = new NetworkCredential(usuarioWS, passwdWS);
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri(WSEndpoint), "NTLM", credential);

            if ("true" == "true")
            {
                log.Debug("GenerarInformeDeGastos - IGNORA_ERROR_CERTI = true.");
                ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;
            }

            log.Debug("GenerarInformeDeGastos - Certificado X509 cargado exitosamente.");


            log.Debug("GenerarInformeDeGastos - Creando Bean");
            var envelope = new Soap.Envelope();
            envelope.Header = new Soap.Header("UsernameToken-1", usuarioWS, passwdWS, WSEndpoint, WSAction);
            envelope.Body = new Soap.Body(data);

            System.Xml.Serialization.XmlSerializerNamespaces xmlnsSoap = new System.Xml.Serialization.XmlSerializerNamespaces();
            xmlnsSoap.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
            xmlnsSoap.Add("inf", "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg");
            xmlnsSoap.Add("inf1", "https://ws-si.mecon.gov.ar/ws/informeDeGastos");
            xmlnsSoap.Add("com", "https://ws-si.mecon.gov.ar/ws/comprobantes");
            xmlnsSoap.Add("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
            xmlnsSoap.Add("wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
            xmlnsSoap.Add("wsa", "http://www.w3.org/2005/08/addressing");


            log.Debug("GenerarInformeDeGastos - Mapeando a objeto XML.");
            string result = Functions.SerializeObjectToString(envelope, xmlnsSoap);

            log.Debug("GenerarInformeDeGastos - Armando header de autenticacion");
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

                var resp = Functions.DeserializeXMLFileToObject<Models.generarInformeDeGastosResponse>(result);

                return resp;

            }
            catch (WebException exp)
            {
                log.Error("GenerarInformeDeGastos - Error en la ejecucion : " + exp.Message);
                //throw exp;
                using (StreamReader sr = new StreamReader(exp.Response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }

                throw new Exception(result);
            }
        }

        public async Task<Models.generarInformeDeGastosResponse> generarInformeDeGastos4(Models.generarInformeDeGastos data)
        {
            string usuarioProxy = "e266864";
            string passwdProxy = "VlaSauco2020";
            string urlProxy = "http://proxysgha.anses.gov.ar:80";
            string domainProxy = "ANSES";

            string usuarioWS = "SAP-850";
            string passwdWS = "AnsesEsidif2019";

            string WSAction = "https://ws-si.mecon.gov.ar/ws/gastos/informeDeGastos/generarInformeDeGastosService";
            string WSEndpoint = "https://tws4-si.mecon.gov.ar/SD_Core/ws/";

            var resp = new Models.generarInformeDeGastosResponse();

            var address = new EndpointAddress(WSEndpoint);
            var binding = new BasicHttpsBinding
            {
                //MaxBufferPoolSize = 524288,
                //MaxBufferSize = 65536,
                MaxReceivedMessageSize = 2147483647,
                TextEncoding = Encoding.UTF8,
                TransferMode = TransferMode.Buffered,
                AllowCookies = false,
                ProxyAddress = new Uri(urlProxy),
                //ProxyAuthenticationScheme = AuthenticationSchemes.Ntlm,
                UseDefaultWebProxy = false,
                BypassProxyOnLocal = false,
                Security =
                {
                    Mode = BasicHttpsSecurityMode.Transport,
                    Transport = new HttpTransportSecurity
                    {
                        ClientCredentialType = HttpClientCredentialType.Certificate,
                        ProxyCredentialType = HttpProxyCredentialType.None
                    }
                }
            };

            var client = new service.generarInformeDeGastosPortTypeClient(binding, address);
            client.ClientCredentials.ClientCertificate.Certificate = Functions.GetClientCertificate();
            // Client certs must be installed
            client.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = new X509ServiceCertificateAuthentication
            {
                CertificateValidationMode = X509CertificateValidationMode.ChainTrust,
                TrustedStoreLocation = StoreLocation.LocalMachine,
                RevocationMode = X509RevocationMode.NoCheck
            };

            var paramMecom = GenericObject<service.generarInformeDeGastos>.GenericMethod();
            Functions.CopyPropertiesTo(data, paramMecom);

            var opContext = new OperationContext(client.InnerChannel);
            var prevOpContext = OperationContext.Current;
            OperationContext.Current = opContext;

            OperationContext.Current.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

            var result = await client.generarInformeDeGastosAsync(paramMecom).ConfigureAwait(false);

            if (result != null)
            {
                Console.WriteLine("akjdhfsjkhfjk");
            }




            //    BasicHttpBinding basicHttpBinding = null;
            //EndpointAddress endpointAddress = null;
            //ChannelFactory<service.generarInformeDeGastosPortType> factory = null;
            //service.generarInformeDeGastosPortType serviceProxy = null;


            //basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            //basicHttpBinding.ProxyAddress = new Uri(urlProxy);
            //basicHttpBinding.UseDefaultWebProxy = false;
            //basicHttpBinding.BypassProxyOnLocal = false;
            //basicHttpBinding.MaxReceivedMessageSize = 2147483647;

            //basicHttpBinding.TextEncoding = Encoding.UTF8;
            //basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            ////basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            //basicHttpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;

            //var customBinding = new CustomBinding(basicHttpBinding);
            //var htbe = customBinding.Elements.Find<HttpTransportBindingElement>();
            //htbe.ProxyAddress = new Uri(urlProxy);
            //htbe.ProxyAuthenticationScheme = AuthenticationSchemes.Ntlm;
            //htbe.UseDefaultWebProxy = false;
            //htbe.BypassProxyOnLocal = false;



            //ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;

            //endpointAddress = new EndpointAddress(new Uri(WSEndpoint));
            //factory = new ChannelFactory<service.generarInformeDeGastosPortType>(customBinding, endpointAddress);

            //factory.Credentials.UserName.UserName = usuarioWS;
            //factory.Credentials.UserName.Password = passwdWS;

            //factory.Credentials.ClientCertificate.Certificate = Functions.GetClientCertificate();

            //factory.Credentials.ServiceCertificate.SslCertificateAuthentication = new System.ServiceModel.Security.X509ServiceCertificateAuthentication()
            //{
            //    CertificateValidationMode = X509CertificateValidationMode.ChainTrust,
            //    TrustedStoreLocation = StoreLocation.LocalMachine,
            //    RevocationMode = X509RevocationMode.NoCheck
            //};

            //serviceProxy = factory.CreateChannel();


            //((ICommunicationObject)serviceProxy).Open();
            //var opContext = new OperationContext((IClientChannel)serviceProxy);
            //opContext.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

            //var prevOpContext = OperationContext.Current;

            //OperationContext.Current = opContext;

            //OperationContext.Current.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

            try
            {

                var param = new service.generarInformeDeGastosRequest();
                param.generarInformeDeGastos = paramMecom;

                //var result = await serviceProxy.generarInformeDeGastosAsync(param).ConfigureAwait(false);

                //if (result != null)
                //{
                //    Console.WriteLine("ahgfhjsdfgjdf");
                //}

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                //factory.Close();
                //((ICommunicationObject)serviceProxy).Close();
                //CloseCommunicationObjects((ICommunicationObject)serviceProxy, factory);
                //OperationContext.Current = prevOpContext;
            }


            return resp;
        }
        public async Task<Models.generarInformeDeGastosResponse> generarInformeDeGastos3(Models.generarInformeDeGastos data)
        {
            string usuarioProxy = "e266864";
            string passwdProxy = "VlaSauco2020";
            string urlProxy = "http://proxysgha.anses.gov.ar:80";
            string domainProxy = "ANSES";

            string usuarioWS = "SAP-850";
            string passwdWS = "AnsesEsidif2019";

            string WSAction = "https://ws-si.mecon.gov.ar/ws/gastos/informeDeGastos/generarInformeDeGastosService";
            string WSEndpoint = "https://tws4-si.mecon.gov.ar/SD_Core/ws/";

            var resp = new Models.generarInformeDeGastosResponse();

            CustomBinding basicHttpBinding = new CustomBinding();
            HttpsTransportBindingElement httpsTransport = null;
            EndpointAddress endpointAddress = null;
            service.generarInformeDeGastosPortTypeClient serviceProxy = null;

            var paramMecom = GenericObject<service.generarInformeDeGastos>.GenericMethod();

            log.Debug("GenerarInformeDeGastos - Seteando PROXY.");
            httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.ProxyAddress = new Uri(urlProxy);
            httpsTransport.UseDefaultWebProxy = false;
            httpsTransport.BypassProxyOnLocal = false;
            httpsTransport.MaxReceivedMessageSize = 2147483647;

            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;

            httpsTransport.AuthenticationScheme = AuthenticationSchemes.Basic;
            endpointAddress = new EndpointAddress(new Uri(WSEndpoint));

            ////var customBindingElement = new CustomTextMessageBindingElement();
            //var customBindingElement = new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8);
            //basicHttpBinding.Elements.Insert(0, customBindingElement);
            basicHttpBinding.Elements.Add(httpsTransport);

            serviceProxy = new service.generarInformeDeGastosPortTypeClient(basicHttpBinding, endpointAddress);

            serviceProxy.ClientCredentials.UserName.UserName = usuarioWS;
            serviceProxy.ClientCredentials.UserName.Password = passwdWS;

            serviceProxy.ClientCredentials.ClientCertificate.Certificate = Functions.GetClientCertificate();

            //((ICommunicationObject)serviceProxy).Open();
            var opContext = new OperationContext(serviceProxy.InnerChannel);
            var prevOpContext = OperationContext.Current;
            OperationContext.Current = opContext;

            try
            {
                Functions.CopyPropertiesTo(data, paramMecom);


                OperationContext.Current.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

                var result = await serviceProxy.generarInformeDeGastosAsync(paramMecom).ConfigureAwait(false);

                if (result != null)
                {
                    Console.WriteLine("ahgfhjsdfgjdf");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                //((ICommunicationObject)serviceProxy).Close();
                //CloseCommunicationObjects((ICommunicationObject)serviceProxy, factory);
                //OperationContext.Current = prevOpContext;
            }


            return resp;
        }
        public async Task<Models.generarInformeDeGastosResponse> generarInformeDeGastos2(Models.generarInformeDeGastos data)
        {
            string usuarioProxy = "e266864";
            string passwdProxy = "VlaSauco2020";
            string urlProxy = "http://proxysgha.anses.gov.ar:80";
            string domainProxy = "ANSES";

            string usuarioWS = "SAP-850";
            string passwdWS = "AnsesEsidif2019";

            string WSAction = "https://ws-si.mecon.gov.ar/ws/gastos/informeDeGastos/generarInformeDeGastosService";
            string WSEndpoint = "https://tws4-si.mecon.gov.ar/SD_Core/ws/";

            var resp = new Models.generarInformeDeGastosResponse();

            var basicHttpBinding = new BasicHttpsBinding
            {
                MaxBufferPoolSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
                ProxyAddress = new Uri(urlProxy),
                UseDefaultWebProxy = false,
                BypassProxyOnLocal = false,
                MaxReceivedMessageSize = 2147483647,
                TextEncoding = Encoding.UTF8,
                TransferMode = TransferMode.Buffered,
                AllowCookies = true,
                ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
                //ReaderQuotas = XmlDictionaryReaderQuotas.Max,
                Security =
                {
                    Mode = BasicHttpsSecurityMode.Transport,
                    Transport = new HttpTransportSecurity
                    {
                        ClientCredentialType = HttpClientCredentialType.Certificate,
                        ProxyCredentialType = HttpProxyCredentialType.None
                    }
                }
            };


            EndpointAddress endpointAddress = null;
            service.generarInformeDeGastosPortTypeClient serviceProxy = null;

            var paramMecom = GenericObject<service.generarInformeDeGastos>.GenericMethod();

            log.Debug("GenerarInformeDeGastos - Seteando PROXY.");

            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationCallback;

            endpointAddress = new EndpointAddress(new Uri(WSEndpoint));


            serviceProxy = new service.generarInformeDeGastosPortTypeClient(basicHttpBinding, endpointAddress);

            serviceProxy.ClientCredentials.UserName.UserName = usuarioWS;
            serviceProxy.ClientCredentials.UserName.Password = passwdWS;

            serviceProxy.ClientCredentials.ClientCertificate.Certificate = Functions.GetClientCertificate();

            //((ICommunicationObject)serviceProxy).Open();
            var opContext = new OperationContext(serviceProxy.InnerChannel);
            var prevOpContext = OperationContext.Current;
            OperationContext.Current = opContext;

            try
            {
                Functions.CopyPropertiesTo(data, paramMecom);


                OperationContext.Current.OutgoingMessageHeaders.Add(new SecurityHeader("UsernameToken-1", usuarioWS, passwdWS));

                var result = await serviceProxy.generarInformeDeGastosAsync(paramMecom).ConfigureAwait(false);

                if (result != null)
                {
                    Console.WriteLine("ahgfhjsdfgjdf");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                //((ICommunicationObject)serviceProxy).Close();
                //CloseCommunicationObjects((ICommunicationObject)serviceProxy, factory);
                //OperationContext.Current = prevOpContext;
            }


            return resp;
        }

        public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // DANGEROUS!  completely disable SSL validation if the test server has a bad Cert / bad Cert chain
            //log.Debug("RemoteCertificateValidationCallback - Entro: Issuer" + certificate.Issuer);

            return true;
        }
    }
}
