using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Palamedes.API.Data;
using Palamedes.API.Models;

namespace Palamedes.API.Repositories
{
    public class BearerHistoryRepository
    {
        public DataContext<IdentityUser> db;

        public BearerHistoryRepository(DataContext<IdentityUser> context)
        {
            db = context;
        }

        public async Task<BearerHistory> CreateBearerHistory(string token, IdentityUser user)
        {

            var bearerEntity = new BearerHistory { BearerToken = token, User = user };

            db.Set<BearerHistory>().Add(bearerEntity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return bearerEntity;
        }

        public async Task<IdentityUser> GetUserFromBearer(string bearer)
        {
            var userBearer = await db.BearerHistories
                    .Include(b => b.User)
                    .Where(b => b.BearerToken == bearer)
                    .FirstOrDefaultAsync();
            var user = userBearer.User;
            return user;
        }
    }
}
