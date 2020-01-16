using G1_ee_groep1_palamedes.SH_MVL.Web.Data;
using G1_ee_groep1_palamedes.SH_MVL.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace G1_ee_groep1_palamedes.SH_MVL.Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("PalamedesArtDb")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddRazorPages();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireMemberRole", policy => policy.RequireRole("Member"));
                options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                options.AddPolicy("RequireManagerRole", policy => policy.RequireRole("Manager"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {

            // Enable Developer 
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   "admin",
                   "admin",
                   "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    "default", "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });


        }
    }
}
