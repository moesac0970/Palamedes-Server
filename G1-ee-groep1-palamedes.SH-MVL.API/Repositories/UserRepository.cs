using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using System.Linq;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class UserRepository : Repository<User>
    {

        public UserRepository(ArtDataContext context) : base(context)
        {
        }

        public virtual User GetByUserName(string username)
        {
            return db.Users
                .Where(u => u.UserName == username)
                .FirstOrDefault();
        }
    }
}
