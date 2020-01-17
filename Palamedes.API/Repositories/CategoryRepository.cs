using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Palamedes.API.Data;
using Palamedes.API.Models;

namespace Palamedes.API.Repositories
{
    public class CategoryRepository : MappingRepository<Category>
    {

        public CategoryRepository(DataContext<IdentityUser> context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
