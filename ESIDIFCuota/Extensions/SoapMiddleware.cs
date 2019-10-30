using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace ESIDIFCuota.Extensions
{
    public class SoapLoggerExtension : SoapExtension
    {
        private static readonly ILog log = LogManager.GetLogger("Cuota");

        /// <summary>
        /// The old stream coming into this extension when we make a soap request.  See ChainStream.
        /// </summary>
        private Stream oldStream;

        /// <summary>
        /// The new stream which will hold our copy of the old stream when swapping places.
        /// </summary>
        private Stream newStream;

        /// <inheritdoc />
        /// <summary>
        /// The chain stream when overridden in a derived class, allows a SOAP extension access to the memory buffer containing the SOAP request or response.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.IO.Stream" />.
        /// </returns>
        public override Stream ChainStream(Stream stream)
        {
            this.oldStream = stream;
            this.newStream = new MemoryStream();
            return this.newStream;
        }

        /// <inheritdoc />
        /// <summary>
        /// The get initializer, see documentation reference.
        /// </summary>
        /// <param name="methodInfo">
        /// The method info.
        /// </param>
        /// <param name="attribute">
        /// The attribute.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Object" />.
        /// </returns>
        public override object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute)
        {
            return null;
        }

        /// <inheritdoc />
        /// <summary>
        /// Another get initializer, see documentation reference.
        /// </summary>
        /// <param name="serviceType">
        /// The service type.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Object" />.
        /// </returns>
        public override object GetInitializer(Type serviceType)
        {
            return null;
        }

        /// <inheritdoc />
        /// <summary>
        /// The initialize, see documentation reference.
        /// </summary>
        /// <param name="initializer">
        /// The initializer.
        /// </param>
        public override void Initialize(object initializer)
        {
        }


        /// <inheritdoc />
        /// <summary>
        /// ProcessMessage processes the soap message.
        /// </summary>
        /// <param name="message">
        /// The incoming soap message.
        /// </param>
        public override void ProcessMessage(SoapMessage message)
        {
            // Log some informational items for reviewing in this sample application.

            switch (message.Stage)
            {
                case SoapMessageStage.BeforeSerialize:
                    break;
                case SoapMessageStage.AfterSerialize:
                    this.WriteOutput(message);
                    break;
                case SoapMessageStage.BeforeDeserialize:
                    this.WriteInput(message);
                    break;
                case SoapMessageStage.AfterDeserialize:
                    //foreach (SoapHeader header in message.Headers)
                    //{
                    //    if (header.Actor == null)
                    //    {

                    //    }
                    //}
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Write the output of the outgoing soap request.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void WriteOutput(SoapMessage message)
        {
            this.newStream.Position = 0;
            var reader = new StreamReader(this.newStream);
            var requestXml = reader.ReadToEnd();
            string salida = System.Web.HttpContext.Current.Request.Url.AbsoluteUri == message.Url ? "Respuesta Servicio - ESIDIF : " : "Consulta Servicio - SAP : ";

            if (message.Url.Contains("enviarmail"))
            {
                salida = "Mail Servicio - SAP : Enviado";
                log.Info(salida);
            }
            else
            {
                log.Info(salida + Environment.NewLine + this.PrettyXml(requestXml));
            }

            this.newStream.Position = 0;
            CopyStream(this.newStream, this.oldStream);
            this.newStream.Position = 0;
        }

        /// <summary>
        /// Write the input of the incoming soap response.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void WriteInput(SoapMessage message)
        {
            CopyStream(this.oldStream, this.newStream);
            this.newStream.Position = 0;
            var reader = new StreamReader(this.newStream);
            var requestXml = reader.ReadToEnd();
            string entrada = System.Web.HttpContext.Current.Request.Url.AbsoluteUri == message.Url ? "Consulta ESIDIF - Servicio : " : "Respuesta SAP - Servicio : ";

            if (message.Url.Contains("enviarmail"))
            {
                entrada = "Mail Servicio - SAP: Ok";
                log.Info(entrada);
            }
            else
            {
                log.Info(entrada + Environment.NewLine + this.PrettyXml(requestXml));
            }

            this.newStream.Position = 0;
        }

        /// <summary>
        /// Copy Stream puts the contents of the toStream into the fromStream.
        /// We are swapping the oldStream and newStream so we can get the request 
        /// and response from the soap message.
        /// </summary>
        /// <param name="fromStream">
        /// The from stream, the value we want to copy to the toStream.
        /// </param>
        /// <param name="toStream">
        /// The to stream, which is change to the value of the fromStream.
        /// </param>
        private static void CopyStream(Stream fromStream, Stream toStream)
        {
            //Logger.Debug("CopyStream");
            try
            {
                var sr = new StreamReader(fromStream);
                var sw = new StreamWriter(toStream);
                sw.WriteLine(sr.ReadToEnd());
                sw.Flush();
            }
            catch (Exception ex)
            {
                var message = "CopyStream failed because: " + ex.Message;
                log.Error(message, ex);
            }
        }

        /// <summary>
        /// Format the Xml to be pretty for humans.
        /// </summary>
        /// <param name="requestXml">
        /// The request Xml.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string PrettyXml(string requestXml)
        {
            try
            {
                string xml = XDocument.Parse(requestXml).ToString();
                return xml;
            }
            catch (Exception ex)
            {
                log.Info("Error al parsear el xml: " + ex.Message);
                return requestXml;
            }
        }
    }

    public class SoapBehavior : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new SoapInspectorBehaviour();
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(SoapInspectorBehaviour);
            }
        }
    }

    public class SoapMessageInspector : IClientMessageInspector
    {
        private static readonly ILog log = LogManager.GetLogger("Cuota");

        public SoapLoggerExtension logSoap = new SoapLoggerExtension();

        public string LastRequestXml
        {
            get;
            private set;
        }

        public string LastResponseXml
        {
            get;
            private set;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            LastResponseXml = reply.ToString();
            log.Info("Respuesta SAP - Servicio : " + Environment.NewLine + logSoap.PrettyXml(LastResponseXml));
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            LastRequestXml = request.ToString();
            log.Info("Consulta Servicio - SAP : " + Environment.NewLine + logSoap.PrettyXml(LastRequestXml));
            return request;
        }
    }

    public class SoapInspectorBehaviour : IEndpointBehavior
    {
        private readonly SoapMessageInspector _soapMessageInspector = new SoapMessageInspector();

        public string LastResponseXml
        {
            get
            {
                return _soapMessageInspector.LastResponseXml;
            }
        }
        public string LastRequestXml
        {
            get
            {
                return _soapMessageInspector.LastRequestXml;
            }
        }
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(_soapMessageInspector);
        }
    }
}