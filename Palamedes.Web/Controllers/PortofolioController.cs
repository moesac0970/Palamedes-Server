using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Palamedes.API.DTO;
using Palamedes.Web.Helper;

namespace Palamedes.Web.Controllers
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