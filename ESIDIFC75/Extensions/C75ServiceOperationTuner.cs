using Microsoft.AspNetCore.Http;
using SoapCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIFC75.Extensions
{
    public class C75ServiceOperationTuner : IServiceOperationTuner
    {
        public void Tune(HttpContext httpContext, object serviceInstance, SoapCore.OperationDescription operation)
        {
            if (operation.Name == "")
            {

            }
        }
    }
}
