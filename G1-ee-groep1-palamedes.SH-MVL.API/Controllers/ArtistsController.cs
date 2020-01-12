using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistsController : ControllerCrudBase<Artist, ArtistsRepository>
    {
        public ArtistsController(ArtistsRepository ArtRepository) : base(ArtRepository)
        {
        }


    }
}