using AutoMapper;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class CategoryRepository : MappingRepository<Category>
    {

        public CategoryRepository(DataContext<IdentityUser> context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
