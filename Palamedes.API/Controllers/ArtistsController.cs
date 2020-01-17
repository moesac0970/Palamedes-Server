using Microsoft.AspNetCore.Mvc;
using Palamedes.API.Models;
using Palamedes.API.Repositories;

namespace Palamedes.API.Controllers
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