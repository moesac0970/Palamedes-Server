using AutoMapper;
using AutoMapper.QueryableExtensions;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class ArtRepository : MappingRepository<Art>
    {
        public ArtRepository(ArtDataContext<IdentityUser> context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<List<ArtBasic>> ListBasic()
        {
            return await db.Arts
                .ProjectTo<ArtBasic>(mapper.ConfigurationProvider)
                .OrderBy(a => a.Name)
                .ToListAsync();
        }

        public async Task<ArtDetail> ListDetail(int id)
        {
            return mapper.Map<ArtDetail>(await db.Arts
                .Include(a => a.Artist)
                .FirstOrDefaultAsync(a => a.ArtistId == id)) ;
        }
        public new async Task<List<Art>> ListAll()
        {
            return await db.Arts
                .Include(a => a.Artist)
                .ToListAsync();
        }

    }
}
