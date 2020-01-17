using Microsoft.AspNetCore.Mvc;

namespace Palamedes.API.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        // Enables polling to api base domain 
        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(200); // Returns an empty page
        }
    }
}
