using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using ESIDIF.Extensions;
using ESIDIFAcumuladores.Extensions;
using log4net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SoapCore;

namespace ESIDIFAcumuladores
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            this.Configuration = configuration;
            this.HostingEnvironment = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostingEnvironment { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton(Configuration.GetSection(typeof(Settings).Name).Get<Settings>());

            services.AddSoapCore();
            services.AddSoapServiceOperationTuner(new AcumuladoresServiceOperationTuner());
            services.AddSingleton(new AcumuladoresService());
            services.AddSoapExceptionTransformer((ex) => ex.Message);

            services.AddMvc(options =>
            {
                options.ReturnHttpNotAcceptable = false;
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
                options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                // If you need to add support for XML
                //options.OutputFormatters.Add(new StringOutputFormatter());
                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", "text/xml");

            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
            .AddXmlSerializerFormatters()
            .AddXmlDataContractSerializerFormatters();
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

            app.UseCors(builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            ILog logger = LogManager.GetLogger(typeof(AcumuladoresService));

            app.UseMiddleware<LogResponseMiddleware>(logger);
            app.UseMiddleware<LogRequestMiddleware>(logger);

            app.UseSoapEndpoint<AcumuladoresService>("/generarCrgOvService.asmx", httpBinding, SoapSerializer.DataContractSerializer);
            app.UseMvc();
        }
    }
}
