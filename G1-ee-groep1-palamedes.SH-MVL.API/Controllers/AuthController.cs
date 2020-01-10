using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using G1_ee_groep1_palamedes.SH_MVL.API.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository db;
        private BearerHistoryRepository BearerRepo;
        private UserManager<IdentityUser> userManager;
        public AuthController(UserRepository context, BearerHistoryRepository bearerHistoryRepository, UserManager<IdentityUser> _userManager)
        {
            db = context;
            BearerRepo = bearerHistoryRepository;
            userManager = _userManager;

        }

        [HttpPost("token")]
        public async Task<IActionResult> Token()
        {
            //todo: simplify constructor
            BearerTokenService generator = new BearerTokenService(db, BearerRepo, userManager);
            var token = await generator.GenerateBearerToken(Request);

            if(token != "not valid user" || token != "wrong request")
            {
                return Ok(token);
            }
            return BadRequest(token);

        }
    }
}