using AutoMapper;
using AutoMapper.QueryableExtensions;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class ArtRepository : MappingRepository<Art>
    {

        public ArtRepository(ArtDataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<List<ArtBasic>> ListBasic()
        {
            return await db.Arts
                .ProjectTo<ArtBasic>(mapper.ConfigurationProvider)
                .OrderBy(b => b.Name)
                .ToListAsync();
        }

    }
}
