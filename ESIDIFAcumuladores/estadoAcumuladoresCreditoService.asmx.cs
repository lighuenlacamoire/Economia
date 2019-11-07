using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ESIDIFAcumuladores
{
    /// <summary>
    /// Descripción breve de estadoAcumuladoresCreditoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class estadoAcumuladoresCreditoService : System.Web.Services.WebService
    {

        [WebMethod]
        public Models.Prueba HelloWorld(Models.Prueba prueba)
        {
            if(prueba == null)
            {
                throw new Exception("aaa");
            }
            else
            {
                return prueba;
            }
        }
    }
}
