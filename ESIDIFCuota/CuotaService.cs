using ESIDIF.Tools;
using ESIDIFCuota.Models.Session;
using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ESIDIFCuota
{
    
    [ServiceContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Name = "CuotaService")]
    public class CuotaService
    {
        private readonly IHttpContextAccessor _httpContext;

        public CuotaService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        private static readonly ILog _logger = LogManager.GetLogger(typeof(CuotaService));

        public User UserSession
        {
            get
            {
                var user = _httpContext.HttpContext.Session.GetObject<User>("UserSession");

                if(user == null)
                {
                    _httpContext.HttpContext.Session.SetObject("UserSession", new User());
                }
                return _httpContext.HttpContext.Session.GetObject<User>("UserSession");
            }
            set
            {
                _httpContext.HttpContext.Session.SetObject("UserSession", value);
            }
        }


        [OperationContract(Action = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg/generarInformeDeGastosPortType")]
        public string generarInformeDeGastosPortType([System.Xml.Serialization.XmlElement("generarInformeDeGastos")]string nose)
        {
            try
            {
                if(!UserSession.HasToken)
                {
                    UserSession = new UserLogged().ObtenerDatosCredencial();
                }



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
