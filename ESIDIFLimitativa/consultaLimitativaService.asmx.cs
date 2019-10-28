using ESIDIFLimitativa.Business;
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
            try
            {
                return _sources.consultarLimitativaCredito(request);
            }
            catch (Exception ex)
            {
                throw _sources.HandleError(ex);
            }
        }
    }
}
