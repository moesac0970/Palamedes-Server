using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Palamedes.API.Models;

namespace Palamedes.API.Repositories
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
