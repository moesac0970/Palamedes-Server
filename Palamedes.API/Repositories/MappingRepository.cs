using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Palamedes.API.Data;
using Palamedes.API.Models;

namespace Palamedes.API.Repositories
{
    /// <summary>
    ///     MappingRepository for mapping entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MappingRepository<T> : Repository<T> where T : EntityBase
    {
        protected readonly IMapper mapper;
        public MappingRepository(DataContext<IdentityUser> context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }
    }
}
