using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIFC75.Extensions
{
    public class Settings
    {
        public static IConfigurationBuilder GetBuilder()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder;
        }

        public static string GetAppSettings(string key)
        {
            var builder = GetBuilder();
            var GetAppStringData = builder.Build().GetValue<string>( key);
            return GetAppStringData;
        }
    }
}
