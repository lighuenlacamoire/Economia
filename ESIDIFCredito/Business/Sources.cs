using ESIDIFCredito.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFCredito.Business
{
    public class Sources
    {
        private static readonly ILog log = LogManager.GetLogger("ESIDIFCreditorecurso");

        //Siempre debemos devolver "OK" incluzo en caso de error
        private static EOuput respuesta = new EOuput { Message = "OK", Type = "S" };

        public Sources()
        {

        }
    }
}