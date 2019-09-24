using ESIDIFCRGOV.Business;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIFCRGOV
{
    [System.ServiceModel.ServiceContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg", Name = "CRGOVService")]
    public class CRGOVService
    {
        private Sources _sources = new Sources();

        [System.ServiceModel.OperationContract(Action = "/generarCrgOv")]
        public Models.crgOvResponse generarCrgOv([System.Xml.Serialization.XmlElement("crgOvRequest")]Models.crgOvRequest data)
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
