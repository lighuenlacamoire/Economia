using ESIDIFAcumuladores.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ESIDIFAcumuladores
{
    [System.ServiceModel.ServiceContract(Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar", Name = "AcumuladoresService")]
    public class AcumuladoresService
    {
        private Sources _sources = new Sources();

        [System.ServiceModel.OperationContract(Action = "/acumuladoresCreditoIndicativa")]
        public Models.acumuladoresCreditoConsulta acumuladoresCreditoIndicativa([System.Xml.Serialization.XmlElement("imputacionCreditoConsulta")]Models.imputacionCreditoConsulta data)
        {
            try
            {
                return _sources.acumuladoresCreditoIndicativaWeb(data);

            }
            catch (WebException exp)
            {
                throw _sources.manejoWebError(exp);
            }
            catch (Exception ex)
            {
                throw _sources.manejoError(ex);
            }
        }

    }
}
