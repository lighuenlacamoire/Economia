using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using ESIDIFCommon.Tools;
using ESIDIFCredito.Business;
using ESIDIFCredito.Models;
using ESIDIFLegacy.Models.Director;

namespace ESIDIFCredito
{
    [WebService(Namespace = "urn:sap-com:document:sap:soap:functions:mc-style", Description = "ESIDIFCredito", Name = "CreditoService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    //Este servivio es consumido por el Ministerio de Economia y accede a SAP
    public class CreditoService : System.Web.Services.WebService
    {
        private Sources _sources = new Sources();

        public CreditoService()
        {
        }


        #region Usuario Token
        private User UsuarioSession
        {
            get
            {
                if (Session["UsuarioSession"] == null)
                    Session["UsuarioSession"] = new User();
                return Session["UsuarioSession"] as User;
            }
            set { Session["UsuarioSession"] = value; }
        }
        #endregion

        public SoapUnknownHeader[] unknownHeaders;

        [WebMethod(Description = "ESIDIFCreditorecurso")]
        [SoapDocumentMethod(Action = "/PresupuestoCredito", ResponseNamespace = "*")]
        [SoapHeader("unknownHeaders")]
        public EOuput PresupuestoCredito([System.Xml.Serialization.XmlElementAttribute("ZfmWsCredito")]ZfmWsCredito consulta)
        {
            try
            {
                return _sources.PresupuestoCredito(consulta,unknownHeaders, UsuarioSession);
            }
            catch (Exception ex)
            {
                throw _sources.HandleError(ex);
            }
        }
    }
}
