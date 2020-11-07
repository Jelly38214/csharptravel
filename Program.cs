using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Faketravel.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /** 
                1.Create virtual host server.
                2.Microsoft.Extensions.Hosting.IHostEnvironment.ContentRootPath, Microsoft.Extensions.Configuration.IConfiguration
                3.appsettings.[Microsoft.Extensions.Configuration.IConfiguration]
                4.Configure Microsoft.Extensions.Logging.ILoggerFactory, dependency injection container
            */

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
