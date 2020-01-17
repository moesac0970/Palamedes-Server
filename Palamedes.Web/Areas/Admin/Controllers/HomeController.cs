using Microsoft.AspNetCore.Mvc;

namespace Palamedes.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Start");
        }
    }
}
