using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Palamedes.API.Data;

namespace Palamedes.API.Repositories
{
    public class UserRepository
    {

        private readonly DataContext<IdentityUser> db;
        public UserRepository(DataContext<IdentityUser> context)
        {
            db = context;
        }

        public async Task<IQueryable<IdentityUser>> GetUsersAsync()
        {
            var users = db.Users.ToList().AsQueryable();
            return await Task.FromResult(users);
        }

        public IdentityUser GetUserByNameAsync(string UserName)
        {
            var user = db.Users
                .Where(u => u.Email == UserName || u.UserName == UserName)
                .FirstOrDefault();

            return user;
        }

        public async Task<List<IdentityRole<string>>> GetRolesById(string id)
        {
            var claims = await db.UserRoles
                                .Where(ur => ur.UserId == id)
                                .ToListAsync();

            List<IdentityRole<string>> roles = new List<IdentityRole<string>>();
            foreach (var claim in claims)
            {
                roles.Add(db.Roles
                            .Where(r => r.Id == claim.RoleId)
                            .FirstOrDefault());
            }

            return roles;

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
