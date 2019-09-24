
using log4net;
using Microsoft.AspNetCore.Http;
using System;
using System.ServiceModel;

namespace ESIDIFCuota
{
    
    [ServiceContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Name = "CuotaService")]
    public class CuotaService
    {
        private readonly HttpContext _httpContext;

        public CuotaService(IHttpContextAccessor contextAccessor )
        {
            _httpContext = contextAccessor.HttpContext;
        }

        private static readonly ILog _logger = LogManager.GetLogger(typeof(CuotaService));

        //public User UserSession
        //{
        //    get
        //    {
        //        var user = _httpContext.Session.GetObject<User>("UserSession");

        //        if(user == null)
        //        {
        //            _httpContext.Session.SetObject("UserSession", new User());
        //        }
        //        return _httpContext.Session.GetObject<User>("UserSession");
        //    }
        //    set
        //    {
        //        _httpContext.Session.SetObject("UserSession", value);
        //    }
        //}


        [OperationContract(Action = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg/generarInformeDeGastosPortType")]
        public string generarInformeDeGastosPortType([System.Xml.Serialization.XmlElement("generarInformeDeGastos")]string nose)
        {
            try
            {
                //if (!UserSession.HasToken)
                //{
                //    UserSession = new UserLogged().ObtenerDatosToken(_httpContext.Request.Headers, "token");
                //}



                if (nose != null)
                {
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
