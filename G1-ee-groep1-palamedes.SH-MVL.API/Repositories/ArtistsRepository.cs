using AutoMapper;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class ArtistsRepository : MappingRepository<Artist>
    {
        public ArtistsRepository(ArtDataContext<IdentityUser> context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
