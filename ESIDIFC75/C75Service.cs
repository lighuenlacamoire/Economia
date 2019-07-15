using ESIDIF.Tools;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ESIDIFC75
{
    [ServiceContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Name = "C75Service")]
    public class C75Service
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(C75Service));

        [OperationContract(Action = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg/generarInformeDeGastosPortType")]
        public string generarInformeDeGastosPortType([System.Xml.Serialization.XmlElement("generarInformeDeGastos")]string nose)
        {
            try
            {
                _logger.Info("Envio: "+nose);
                if (nose != null)
                {
                    return Functions.AregarAlgo(nose);
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