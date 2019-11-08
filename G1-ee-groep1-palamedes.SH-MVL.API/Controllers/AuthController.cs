using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserRepository db;
        public AuthController(UserRepository context)
        {
            db = context;
        }
        [HttpPost("token")]
        public IActionResult Token()
        {
            //string tokenString = "test";
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                // header begins with 'Basic', and after follows base64encoded logincredentials 
                var credValue = header.ToString().Substring("Basic ".Length).Trim();
                // logincredentials decoded from base64 and put into variable
                var usernameAndPassenc = Encoding.UTF8.GetString(Convert.FromBase64String(credValue)); //admin:pass
                // put into string array 
                var usernameAndPass = usernameAndPassenc.Split(":");
                var user = db.GetUserByIdAsync(usernameAndPassenc);
                //check in DB username and pass exist
                if (usernameAndPass[0] == "SEPPMVl" && usernameAndPass[1] == "palamedes")
                {
                    var claimsdata = new[] { new Claim(ClaimTypes.Name, usernameAndPass[0]) };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("lkjqsdflkjsdfkljqsdfkljqsdlkfjslqdkfjlskdfjlskqdjfhlk"));
                    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                         issuer: "palamedes.be",
                         audience: "palamedes.be",
                         expires: DateTime.Now.AddMinutes(1),
                         claims: claimsdata,
                         signingCredentials: signInCred
                        );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(tokenString);
                }
            }
            return BadRequest("wrong request");
        }
    }
}