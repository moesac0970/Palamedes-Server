using AutoMapper;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
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
    }
}
