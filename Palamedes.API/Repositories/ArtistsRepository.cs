using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Palamedes.API.Data;
using Palamedes.API.Models;

namespace Palamedes.API.Repositories
{
    public class ArtistsRepository : MappingRepository<Artist>
    {
        public ArtistsRepository(DataContext<IdentityUser> context, IMapper mapper) : base(context, mapper)
        {
        }

        //GET: artists/{id}
        public override async Task<Artist> GetById(long id)
        {
            return await db.Artists
                .Include(a => a.User)
                .Where(a => a.Id == id)
                .FirstAsync();
        }

        //GET: artists
        public override async Task<IEnumerable<Artist>> ListAll()
        {
            return await db.Artists
                .Include(a => a.User)
                .ToListAsync();
        }

        public Artist GetByUserId(string id)
        {
            return db.Artists
                .Where(a => a.UserId == id)
                .FirstOrDefault();
        }

        public override async Task<Artist> Add(Artist artist)
        {
            db.Set<Artist>().Add(artist);
            try
            {
                await db.SaveChangesAsync();
                string directorypath = Path.Combine(Directory.GetCurrentDirectory(),
                             "wwwroot", $"img/");
                Directory.CreateDirectory(directorypath + artist.ArtistName);
            }
            catch
            {
                return null;
            }
            return artist;
        }
    }
}
