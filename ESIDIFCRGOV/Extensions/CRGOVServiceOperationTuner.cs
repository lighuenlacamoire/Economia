using Microsoft.AspNetCore.Http;
using SoapCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIFCRGOV.Extensions
{
    public class CRGOVServiceOperationTuner : IServiceOperationTuner
    {
        public void Tune(HttpContext httpContext, object serviceInstance, SoapCore.OperationDescription operation)
        {
        }
    }
}
