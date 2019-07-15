using ESIDIF.Tools;
using log4net;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIF.Configuration
{
    public class LogResponseMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILog _logger;

        public LogResponseMiddleware(RequestDelegate next, ILog logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var bodyStream = context.Response.Body;

            var responseBodyStream = new MemoryStream();
            context.Response.Body = responseBodyStream;

            await _next(context);

            responseBodyStream.Seek(0, SeekOrigin.Begin);
            var responseBody = new StreamReader(responseBodyStream).ReadToEnd();
            _logger.Info($"RESPONSE LOG: {responseBody}");
            _logger.Info("Respuesta Servicio - SAP: "+ Environment.NewLine + Functions.ParseXml(responseBody));

            //_logger.Log(LogLevel.Information, 1, $"RESPONSE LOG: {responseBody}", null, _defaultFormatter);
            responseBodyStream.Seek(0, SeekOrigin.Begin);
            await responseBodyStream.CopyToAsync(bodyStream);
        }
    }
}
