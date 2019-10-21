using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Controllers
{
    public class PortofolioController : Controller
    {
        string baseUri = "https://api.palamedes.be/arts/";
        public async Task<IActionResult> Index()
        {
            string uri = $"{baseUri}/basic";
            return View(WebApiHelper.GetApiResult<List<ArtBasic>>(uri));
        }
    }
}