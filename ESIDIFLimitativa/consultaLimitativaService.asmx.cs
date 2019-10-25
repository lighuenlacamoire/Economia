using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ESIDIFLimitativa
{
    [WebService(Namespace = "http://mecon.anses.gov.ar/", Description = "ESIDIFLimitativa", Name = "LimitativaService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class consultaLimitativaService : System.Web.Services.WebService
    {
        private Sources _sources = new Sources();

        [WebMethod]
        //[SoapDocumentMethod(Action = "/consultarLimitativaCredito")]
        //  public   ESIDIFLimitativa.service.imputacionCreditoConsulta consultarLimitativaCredito(ESIDIFLimitativa.service.consultarLimitativaCreditoRequest request)
        public Models.imputacionCreditoConsulta consultarLimitativaCredito(Models.consultarLimitativaCreditoRequest request)
        {
            Models.imputacionCreditoConsulta ret = null;
            try
            {
                ret = hr.consultarLimitativaCredito(request);
            }
            catch (Exception ex)
            {
                myThrow(ex, Username, "Limitativa");
            }
            return ret;
        }

        public void myThrow(Exception ex, string Username, string Metodo)
        {

            // Build the detail element of the SOAP fault.
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();

            System.Xml.XmlNode node = doc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

            System.Xml.XmlNode details = doc.CreateNode(XmlNodeType.Element, "Detalle", "http://z2.anses.gov.ar/");
            details.InnerText = "Metodo: " + Metodo + " Usuario - [" + Username + "] Mensaje: " + ex.Message;

            ex = hr.CapturarSoapError(ex);


            node.AppendChild(details);

            //Throw the exception    
            SoapException se = new SoapException("Error", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, ex);

            log.Error(Metodo, ex);

            throw se;

        }
    }
}
