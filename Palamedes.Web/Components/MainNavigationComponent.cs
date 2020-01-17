using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Palamedes.Web.ViewModels.Components;

namespace Palamedes.Web.Components
{
    [ViewComponent(Name = "MainNavigation")]
    public class MainNavigationComponent : ViewComponent
    {
        private IEnumerable<MainNavLinkVm> PublicLinks { get; set; }
        private IEnumerable<MainNavLinkVm> AdminLinks { get; set; }


        public MainNavigationComponent()
        {
            PublicLinks = new List<MainNavLinkVm>
            {
                new MainNavLinkVm {Area=null, Controller="Home", Action="Index", Text="Home"},
                new MainNavLinkVm {Area=null, Controller="portofolio", Action="Index", Text="portofolio"},
                new MainNavLinkVm {Area="Identity", Controller="Portofolio", Action="Portfolio", Text="my portofolio" , IsLoggedIn=true},
                new MainNavLinkVm {Area="Identity",  Controller="Account", Action="Login", Text="Login" },
                new MainNavLinkVm {Area="Identity", Controller="Account", Action="Register", Text="Register" },
                new MainNavLinkVm {Area="Identity", Controller="Account", Action="Logout", Text="Logout", IsLoggedIn=true}
            };

            AdminLinks = new List<MainNavLinkVm>
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
            var navLinks = PublicLinks;
            if (showAdmin) navLinks = AdminLinks;
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
