using G1_ee_groep1_palamedes.SH_MVL.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Services
{
    public class BearerTokenService
    {
        private readonly UserRepository db;
        private BearerHistoryRepository BearerRepo;
        private UserManager<IdentityUser> usermnr;

        public BearerTokenService(UserRepository context, BearerHistoryRepository bearerHistoryRepository, UserManager<IdentityUser> userManager)
        {
            db = context;
            BearerRepo = bearerHistoryRepository;
            usermnr = userManager;
        }
        public async Task<string> GenerateBearerToken(HttpRequest request)
        {



            var header = request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                // header begins with 'Basic', and after follows base64encoded logincredentials 
                var credValue = header.ToString().Substring("Basic ".Length).Trim();
                // logincredentials decoded from base64 and put into variable
                var username = Encoding.UTF8.GetString(Convert.FromBase64String(credValue)); //admin:pass
                // put into string array 
                var user = db.GetUserByNameAsync(username);

               
                if (user != null)
                {
                    var roles = await db.GetRolesById(user.Id);

                    var claimsdata = new List<Claim>
                    { 
                        new Claim(ClaimTypes.Name, user.UserName)
                    };

                    foreach(var role in roles)
                    {
                        claimsdata.Add(new Claim(ClaimTypes.Role, role.Name));
                    }

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("lkjqsdflkjsdfkljqsdfkljqsdlkfjslqdkfjlskdfjlskqdjfhlk"));
                    var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                    var token = new JwtSecurityToken(
                         issuer: "palamedes.be",
                         audience: "palamedes.be",
                         expires: DateTime.Now.AddMinutes(60),
                         claims: claimsdata,
                         signingCredentials: signInCred
                        );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    //Update BearerHistory DB
                    await BearerRepo.CreateBearerHistory(tokenString, user);


                    return tokenString;
                }
                return "not valid user";
            }
            return "wrong request";
        }

         
    }
}
