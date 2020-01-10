using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Identity.Pages.Portofolio
{
    [Authorize]
    public class PortfolioModel : PageModel
    {
        public string Name;
        public void OnGet()
        {
            Name = "scared";
        }
    }
}
