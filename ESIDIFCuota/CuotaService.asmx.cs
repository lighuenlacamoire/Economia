using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using ESIDIFCuota.Business;
using ESIDIFCuota.Models;
using ESIDIFLegacy.Models.Director;

namespace ESIDIFCuota
{
    [WebService(Namespace = "urn:sap-com:document:sap:soap:functions:mc-style", Description = "ESIDIFCuota", Name = "CuotaService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    //Este servivio es consumido por el Ministerio de Economia y accede a SAP
    public class CuotaService : System.Web.Services.WebService
    {
        private Sources _sources = new Sources();

        public CuotaService()
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


        [WebMethod(Description = "ESIDIFCuota")]
        [SoapDocumentMethod(Action = "/PresupuestoCuota", ResponseNamespace = "*")]
        [SoapHeader("unknownHeaders")]
        public EOuput PresupuestoCuota([System.Xml.Serialization.XmlElementAttribute("ZfmWsCuota")]ZfmWsCuota consulta)
        {
            try
            {
                return _sources.PresupuestoCuota(consulta, unknownHeaders, UsuarioSession);
            }
            catch (Exception ex)
            {
                throw _sources.HandleError(ex);
            }
        }
    }
}