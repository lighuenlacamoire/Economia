using ESIDIFC75.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ESIDIFC75
{
    [ServiceContract(Namespace ="https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Name ="C75Service")]
    public class C75Service
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(C75Service));
        private Service.TramitesFacadeClient svc = new Service.TramitesFacadeClient();

        [OperationContract(Action = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg/generarInformeDeGastosPortType")]
        [System.w]
        public string generarInformeDeGastosPortType([System.Xml.Serialization.XmlElement("generarInformeDeGastos")]MyCustomModel customModel)
        {
            try
            {
                var nose = svc.obtenerTramitesNivel5Async().Result;

                if(nose != null)
                {
                    return "Ok";
                }
                else
                {
                    return "Error";
                }
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
