using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using Microsoft.AspNetCore.Mvc;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtsController : ControllerCrudBase<Art, ArtRepository>
    {
        public ArtsController(ArtRepository ArtRepository) : base(ArtRepository)
        {
           
        }

     }
}