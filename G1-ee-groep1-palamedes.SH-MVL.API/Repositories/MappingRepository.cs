using AutoMapper;
using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    /// <summary>
    ///     MappingRepository for mapping entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MappingRepository<T> : Repository<T> where T : EntityBase
    {
        protected readonly IMapper mapper;
        public MappingRepository(ArtDataContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }
    }
}
