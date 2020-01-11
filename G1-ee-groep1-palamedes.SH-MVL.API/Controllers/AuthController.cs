using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using G1_ee_groep1_palamedes.SH_MVL.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository db;
        private readonly BearerHistoryRepository BearerRepo;
        public AuthController(UserRepository context, BearerHistoryRepository bearerHistoryRepository)
        {
            db = context;
            BearerRepo = bearerHistoryRepository;
        }

        [HttpPost("token")]
        public async Task<IActionResult> Token()
        {
            //todo: simplify constructor
            BearerTokenService generator = new BearerTokenService(db, BearerRepo);
            var token = await generator.GenerateBearerToken(Request);

            if (token != "not valid user" || token != "wrong request")
            {
                return Ok(token);
            }
            return BadRequest(token);

        }
    }
}