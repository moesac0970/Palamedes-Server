using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API
{
    interface IRepository<T> where T : EntityBase
    {
        Task<T> GetById(long id);
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> ListAll();
        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task<T> Delete(T entity);
        Task<T> Delete(long id);
        Task<T> Update(T entity);
    }
}
