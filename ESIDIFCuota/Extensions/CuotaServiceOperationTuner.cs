using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using SoapCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIFCuota.Extensions
{
    public class CuotaServiceOperationTuner : IServiceOperationTuner
    {
        public void Tune(HttpContext httpContext, object serviceInstance, SoapCore.OperationDescription operation)
        {
            
            if (operation.Name == "")
            {

            }
        }
    }
}
