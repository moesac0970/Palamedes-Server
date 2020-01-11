using G1_ee_groep1_palamedes.SH_MVL.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace G1_ee_groep1_palamedes.SH_MVL.Web
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var serviceProvider = services.GetRequiredService<IServiceProvider>();
                    var configuration = services.GetRequiredService<IConfiguration>();
                    SeedRoles.CreateRoles(serviceProvider, configuration).Wait();

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.InnerException);
                }
            }

            CreateHostBuilder(args).Build().Run();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseUrls("http://localhost:5001");
                });


    }
}
