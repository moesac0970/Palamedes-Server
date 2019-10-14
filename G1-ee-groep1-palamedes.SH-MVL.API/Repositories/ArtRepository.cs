using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class ArtRepository : Repository<Art>
    {

        public ArtRepository(ArtDataContext context) : base(context)
        {
        }

    }
}
