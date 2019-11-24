using G1_ee_groep1_palamedes.SH_MVL.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
