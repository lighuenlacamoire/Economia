using ESIDIFC75.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;

namespace ESIDIFC75
{
    /// <summary>
    /// Descripción breve de generarInformeDeGastosC75
    /// </summary>
    [WebService(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Description = "ESIDIFC75", Name = "C75Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    [System.ComponentModel.ToolboxItem(false)]
    public class generarInformeDeGastosC75 : System.Web.Services.WebService
    {
        private Sources _sources = new Sources();

        [WebMethod()]
        public Models.generarInformeDeGastosResponse generarInformeDeGastosPortType(Models.generarInformeDeGastos generarInformeDeGastos)
        {
            try
            {
                return _sources.generarInformeDeGastosWeb(generarInformeDeGastos);
            }
            catch (WebException exp)
            {
                throw _sources.HandleError(exp);
            }
            catch (Exception ex)
            {
                throw _sources.HandleError(ex);
            }
        }
    }
}
