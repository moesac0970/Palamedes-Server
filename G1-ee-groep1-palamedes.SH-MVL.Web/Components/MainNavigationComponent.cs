using G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels.Components;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Components
{
    [ViewComponent(Name = "MainNavigation")]
    public class MainNavigationComponent : ViewComponent
    {
        private IEnumerable<MainNavLinkVm> publicLinks { get; set; }
        private IEnumerable<MainNavLinkVm> adminLinks { get; set; }


        public MainNavigationComponent()
        {
            publicLinks = new List<MainNavLinkVm>
            {
                new MainNavLinkVm {Area=null, Controller="Home", Action="Index", Text="Home"},
                new MainNavLinkVm {Area=null, Controller="portofolio", Action="Index", Text="portofolio"},
                new MainNavLinkVm {Area=null, Controller="store", Action="Index", Text="Store"},
                new MainNavLinkVm {Area=null, Controller="login/logout", Action="Index", Text="Login"}
            };

            adminLinks = new List<MainNavLinkVm>
            {
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Start"},
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Contact"},
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Store"},
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Login"},
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Portofolio"},
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Profile"},
                new MainNavLinkVm {Area="Admin", Controller="Home", Action="Index", Text="Profile"}

            };
        }

        public async Task<IViewComponentResult> InvokeAsync(bool showAdmin)
        {
            var navLinks = publicLinks;
            if (showAdmin) navLinks = adminLinks;
            foreach (var link in navLinks)
            {
                if (this.RouteData.Values["area"]?.ToString().ToLower() == link.Area?.ToLower() &&
                   this.RouteData.Values["controller"]?.ToString().ToLower() == link.Controller.ToLower() &&
                   this.RouteData.Values["action"]?.ToString().ToLower() == link.Action.ToLower())
                {
                    link.IsActive = true;
                }
            }
            return await Task.FromResult<IViewComponentResult>(View(navLinks));
        }

    }
}
