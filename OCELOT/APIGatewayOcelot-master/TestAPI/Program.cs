using System;
using Megaphone.Core;
using Megaphone.Core.ClusterProviders;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using TestAPI;

namespace ValuesAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var uri = Cluster.Bootstrap(new WebApiProvider(), new ConsulProvider(), "valueapi", "v1");
            CreateWebHostBuilder(args, uri).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args, Uri uri) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.json");
                    config.AddEnvironmentVariables();
                })
                .UseStartup<Startup>()
                .UseUrls($"http://0.0.0.0:{uri.Port}");
    }
}