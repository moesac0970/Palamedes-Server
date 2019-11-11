using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Services
{
    public class BearerTokenService
    {
        private readonly UserRepository db;

        public BearerTokenService(UserRepository context)
        {
            db = context;           
        }
        public async Task<string> GenerateBearerToken(HttpRequest request)
        {
            var header = request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                // header begins with 'Basic', and after follows base64encoded logincredentials 
                var credValue = header.ToString().Substring("Basic ".Length).Trim();
                // logincredentials decoded from base64 and put into variable
                var usernameAndPassHash = Encoding.UTF8.GetString(Convert.FromBase64String(credValue)); //admin:pass
                // put into string array 
                var user = db.GetUserByNameAsync(usernameAndPassHash);
                if (user != null)
                {
                    var claimsdata = new[] { new Claim(ClaimTypes.Name, user.UserName) };
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

                    //update user id with bearer token 
                    user.Id = tokenString;
                    await db.UpdateUser(user);

                    return tokenString;
                }
                return "not valid user";
            }
            return "wrong request";
        }

         
    }
}
