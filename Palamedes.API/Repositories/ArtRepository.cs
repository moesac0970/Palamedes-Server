using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Palamedes.API.Data;
using Palamedes.API.DTO;
using Palamedes.API.Models;

namespace Palamedes.API.Repositories
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

        public async Task<List<ArtBasic>> GetBasicsByArtist(Artist artist)
        {
            var arts = await ListBasic();
            var basics = arts.Where(a => a.ArtistName == artist.ArtistName).ToList() ;

            return basics;
        }
    }
}
