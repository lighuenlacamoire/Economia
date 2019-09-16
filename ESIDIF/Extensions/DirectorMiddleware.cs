using ESIDIF.Tools;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ESIDIF.Extensions
{
    public class DirectorMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILog _logger;

        public DirectorMiddleware(RequestDelegate next, ILog logger)
        {
            this.next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var requestBodyStream = new MemoryStream();
            var originalRequestBody = context.Request.Body;

            await context.Request.Body.CopyToAsync(requestBodyStream);
            requestBodyStream.Seek(0, SeekOrigin.Begin);

            var url = UriHelper.GetDisplayUrl(context.Request);
            var requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();

            _logger.Info($"REQUEST METHOD: {context.Request.Method}, REQUEST BODY: {requestBodyText}, REQUEST URL: {url}");
            _logger.Info("Consulta SAP - Servicio: " + Environment.NewLine + Functions.ParseXml(requestBodyText));

            Buscarlog(requestBodyText, ref context);

            //_logger.Log(LogLevel.Information, 1, $"REQUEST METHOD: {context.Request.Method}, REQUEST BODY: {requestBodyText}, REQUEST URL: {url}", null, _defaultFormatter);

            requestBodyStream.Seek(0, SeekOrigin.Begin);
            context.Request.Body = requestBodyStream;

            await next(context);
            context.Request.Body = originalRequestBody;
        }

        private static void Buscarlog(string request, ref HttpContext httpContext)
        {
            //verificar del token
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.LoadXml(request);
                XmlElement root = xd.DocumentElement;
                var nose = root.GetElementsByTagName("token");

                string valor = nose[0].InnerText;

                if (!string.IsNullOrEmpty(valor) && valor.Length > 20)
                {
                    httpContext.Request.Headers.Add("token", valor);
                }
                else
                {
                    throw new Exception("No se ha enviado el token");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
