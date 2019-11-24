using G1_ee_groep1_palamedes.SH_MVL.API.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Controllers
{
    public class PortofolioController : Controller
    {
        private IConfiguration Configuration { get; }
        private string baseUri;

        public PortofolioController(IConfiguration configuration)
        {
            Configuration = configuration;
            baseUri = Configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
        }
        public async Task<IActionResult> Index()
        {
            string uri = baseUri + "arts/basic";
            return View(await WebApiHelper.GetApiResultAsync<List<ArtBasic>>(uri));
        }
    }
}