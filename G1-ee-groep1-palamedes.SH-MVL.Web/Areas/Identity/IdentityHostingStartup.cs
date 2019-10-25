using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity.IdentityHostingStartup))]
namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}