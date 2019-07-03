﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using ESIDIFC75.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SoapCore;
using static ESIDIFC75.Configuration.RequestResponseLoggingMiddleware;

namespace ESIDIFC75
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.TryAddSingleton<Service.TramitesFacade, Service.TramitesFacadeClient>();
            //services.AddSingleton(new Service.TramitesFacadeClient());
            services.AddSingleton(new C75Service());
            services.AddSoapExceptionTransformer((ex) => ex.Message);
            services.AddMvc(options =>
            {
                options.ReturnHttpNotAcceptable = false;
                // If you need to add support for XML
                options.OutputFormatters.Add(new StringOutputFormatter());

            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var httpBinding = new BasicHttpBinding
            {
                AllowCookies = true,
                MaxReceivedMessageSize = 2147483647,
                MaxBufferPoolSize = 2147483647,
                ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas
                {
                    MaxDepth = 2147483647,
                    MaxStringContentLength = 2147483647,
                    MaxArrayLength = 2147483647,
                    MaxBytesPerRead = 2147483647,
                    MaxNameTableCharCount = 2147483647
                },
                Security =
                {
                    Mode = BasicHttpSecurityMode.Transport,
                    Transport = new HttpTransportSecurity
                    {
                        ClientCredentialType = HttpClientCredentialType.None
                    }
                }
            };
            
            Action<RequestProfilerModel> requestResponseHandler = requestProfilerModel =>
            {
                //Debug.Print(requestProfilerModel.Request);
                //Debug.Print(Environment.NewLine);
                //Debug.Print(requestProfilerModel.Response);
            };
            app.UseMiddleware<RequestResponseLoggingMiddleware>(requestResponseHandler);

            //Add our new middleware to the pipeline
            //app.UseSoapEndpoint<Service.TramitesFacade>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
            app.UseSoapEndpoint<C75Service>("/generarInformeDeGastosC75.asmx", httpBinding, SoapSerializer.XmlSerializer);
            app.UseMvc();
        }
    }
}
