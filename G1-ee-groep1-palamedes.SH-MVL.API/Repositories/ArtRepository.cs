using AutoMapper;
using AutoMapper.QueryableExtensions;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.DTO;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class ArtRepository : MappingRepository<Art>
    {
        public ArtRepository(DataContext<IdentityUser> context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<List<ArtBasic>> ListBasic()
        {
            return await db.Arts
                .ProjectTo<ArtBasic>(mapper.ConfigurationProvider)
                .OrderBy(a => a.Name)
                .ToListAsync();
        }

        public async Task<ArtDetail> ListDetail(long id)
        {
            return mapper.Map<ArtDetail>(await db.Arts
                .Include(a => a.Artist).Include(b => b.Category)
                .FirstOrDefaultAsync(a => a.ArtistId == id));
        }
        public override async Task<IEnumerable<Art>> ListAll()
        {
            return await db.Arts
                .Include(a => a.Artist).Include(a => a.Category)
                .ToListAsync();
        }

        public override async Task<Art> GetById(long id)
        {
            return await db.Arts
                .Include(a => a.Artist).Include(a => a.Category)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Art>> GetByArtist(Artist artist)
        {
            return await db.Arts
                .Where(a => a.Artist == artist)
                .ToListAsync();
        }
    }
}
