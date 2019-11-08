using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class UserRepository 
    {

        private ArtDataContext<IdentityUser> db;
        public UserRepository(ArtDataContext<IdentityUser> context)
        {
            db = context;
        }

        public async Task<IQueryable<IdentityUser>> GetUsersAsync()
        {
            var users = db.Users.ToList().AsQueryable();
            return await Task.FromResult(users);
        }

        public async Task<IdentityUser> GetUserByIdAsync(string nameNPass)
        {
            //todo split nameNpass find user in auth controller
            var usernameAndPass = nameNPass.Split(":");

            var user = db.Users.Where(u => u.Email == usernameAndPass[0]).LastOrDefault();
            return await Task.FromResult(user);
        }
    }
}
