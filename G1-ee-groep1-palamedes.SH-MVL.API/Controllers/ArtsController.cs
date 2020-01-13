
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
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

        [HttpPost]
        [Route("ImageArtistName/{name}")]
        [Authorize]
        public async Task<IActionResult> Image(string name, IFormFile formFile)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                             "wwwroot", $"img/{name}/", formFile.FileName);

            Art art = repository.GetAll().Where(a => a.Artist.ArtistName == name).LastOrDefault();
            art.ImageName = formFile.FileName;
            await repository.Update(art);

            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            }

            return Ok(new { count = 1, formFile.Length });

        }
    }
}
