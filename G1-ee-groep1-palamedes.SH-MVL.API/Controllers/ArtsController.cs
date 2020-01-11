
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtsController : ControllerCrudBase<Art, ArtRepository>
    {
        public ArtsController(ArtRepository ArtRepository) : base(ArtRepository)
        {

        }

        [HttpGet]
        [Route("Basic")]
        public async Task<IActionResult> GetArtBasic()
        {
            return Ok(await repository.ListBasic());
        }

        [HttpGet]
        [Route("ImageByName/{filename}")]
        public IActionResult ImageByFileName(string filename)
        {
            string[] artistAndPath = filename.ToLower().Split(":");
            string image = Path.Combine(Directory.GetCurrentDirectory(),
                             "wwwroot", $"img/{artistAndPath[0]}", artistAndPath[1]);
            return PhysicalFile(image, "image/jpeg");
        }
    }
}
