using log4net;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESIDIF.Tools;
using System.IO;
using System.Xml;
using Microsoft.AspNetCore.Http.Internal;

namespace ESIDIFC75.Configuration
{
    public class SoapMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILog _log;
        private readonly Extensions _extensions = new Extensions();

        public SoapMiddleware(RequestDelegate next, Type type)
        {
            _next = next;
            _log = LogManager.GetLogger(type);
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Request.EnableRewind();

            HttpRequest request = httpContext.Request;

            var nose = "";// _extensions.FormatRequest2(request);

            if(!string.IsNullOrEmpty(nose))
            {
                Console.WriteLine("kjsdhfjsdhfdsjk+ no");
            }

            try
            {
                var originalResponseBody = httpContext.Response.Body;
                using (MemoryStream stream = new MemoryStream())
                {

                     await _next(httpContext);

                    stream.Seek(0, SeekOrigin.Begin);
                    var responseBody = new StreamReader(stream).ReadToEnd();

                    stream.Seek(0, SeekOrigin.Begin);
                    await stream.CopyToAsync(originalResponseBody);
                }

            }
            // Never caught, because LogException() returns false.
            catch (Exception ex)
            {
            }
        }
    }

}
