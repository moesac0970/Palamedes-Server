using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        public IdentityUser GetUserByNameAsync(string nameNPass)
        {
            //todo split nameNpass find user in auth controller
            var usernameAndPass = nameNPass.Split(":");
            var usernameorEmail = usernameAndPass[0];
            var paswHash = usernameAndPass[1];

            var user = db.Users
                .Where(u => u.Email == usernameorEmail || u.UserName == usernameorEmail)
                .Where(u => u.PasswordHash == paswHash)
                .FirstOrDefault();

            return user;
        }

        public async Task<IdentityUser> UpdateUser(IdentityUser user) 
        {
            var oldUser = db.Users.Where(u => u.UserName == user.UserName).FirstOrDefault();
            db.Users.Remove(oldUser);
            db.Users.Add(user);
            return await Task.FromResult(user);
        }

        public async Task<IdentityUser> GetUserByBearerAsync(string bearer)
        {
            //get user by bearer with include
            var userBearer = await db.BearerHistories
                    .Include(b => b.User)
                    .Where(b => b.BearerToken == bearer)
                    .FirstOrDefaultAsync();
            var user = userBearer.User;
            return user;
        }

    }
}
