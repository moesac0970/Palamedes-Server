using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    public class HomeController : Controller
    {
        // Enables polling to api base domain 
        public IActionResult Get()
        {
            return StatusCode(200); // Returns an empty page
        }
    }
}
