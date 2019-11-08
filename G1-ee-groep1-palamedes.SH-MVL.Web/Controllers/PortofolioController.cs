using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Controllers
{
    public class PortofolioController : Controller
    {
        readonly string baseUri = "https://api.palamedes.be/arts/";
        public async Task<IActionResult> Index()
        {
            string uri = $"{baseUri}basic";
            return View(await WebApiHelper.GetApiResultAsync<List<ArtBasic>>(uri));
        }
    }
}