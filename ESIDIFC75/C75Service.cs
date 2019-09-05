using log4net;
using ESIDIFC75.Business;
using System;
using ESIDIF.Models;
using Microsoft.Extensions.Options;

namespace ESIDIFC75
{
    [System.ServiceModel.ServiceContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Name = "C75Service")]
    public class C75Service
    {
        private Sources _sources = new Sources();
                
        private static readonly ILog _logger = LogManager.GetLogger(typeof(C75Service));

        [System.ServiceModel.OperationContract(Action = "/generarInformeDeGastosPortType")]
        public Models.generarInformeDeGastosResponse generarInformeDeGastosPortType([System.Xml.Serialization.XmlElement("generarInformeDeGastos")]Models.generarInformeDeGastos data)
        {
            try
            {
                var request = _sources.generarInformeDeGastosPortTypeWeb(data);

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