using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using log4net;
using SoapCore;
using ESIDIF.Extensions;
using System;
using Microsoft.AspNetCore.Http;
using ESIDIF.Tools;
using ESIDIFCuota.Extensions;
using ESIDIF.Models;

namespace ESIDIFCuota
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            HostingEnvironment = environment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //services.TryAddSingleton<Service.TramitesFacade, Service.TramitesFacadeClient>();
            //services.AddSingleton(new Service.TramitesFacadeClient());
            services.AddSoapExceptionTransformer((ex) => ex.Message);
            services.AddSoapCore();
            services.AddSoapServiceOperationTuner(new CuotaServiceOperationTuner());

            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<CuotaService>();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(15);
            });
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

            //Action<RequestProfilerModel> requestResponseHandler = requestProfilerModel =>
            //{
            //    //Debug.Print(requestProfilerModel.Request);
            //    //Debug.Print(Environment.NewLine);
            //    //Debug.Print(requestProfilerModel.Response);
            //};
            //app.UseMiddleware<RequestResponseLoggingMiddleware>(requestResponseHandler);

            // Enable CORS 
            app.UseCors(builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            ILog logger = LogManager.GetLogger(typeof(CuotaService));

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMiddleware<LogResponseMiddleware>(logger);
            app.UseMiddleware<LogRequestMiddleware>(logger);
            app.UseMiddleware<DirectorMiddleware>(logger);

            app.UseSoapEndpoint<CuotaService>("/CuotaService.asmx", httpBinding, SoapSerializer.XmlSerializer);
            app.UseMvc();
        }
    }

}
