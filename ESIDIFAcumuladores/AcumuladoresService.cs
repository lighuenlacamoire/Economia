using ESIDIFAcumuladores.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIFAcumuladores
{
    [System.ServiceModel.ServiceContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg", Name = "AcumuladoresService")]
    public class AcumuladoresService
    {
        private Sources _sources = new Sources();

        [System.ServiceModel.OperationContract(Action = "/generarCrgOv")]
        public Models.acumuladoresCreditoConsulta generarCrgOv([System.Xml.Serialization.XmlElement("crgOvRequest")]Models.imputacionCreditoConsulta data)
        {
            try
            {
                var request = _sources.generarCrgOvWeb(data);

                return request;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

            return null;
        }

    }
}
