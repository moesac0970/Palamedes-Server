using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public DataContext<IdentityUser> db;

        public Repository(DataContext<IdentityUser> context)
        {
            db = context;
        }

        //GET: arts/{id}
        public virtual async Task<T> GetById(long id)
        {
            return await db.Set<T>()
                .FindAsync(id);
        }

        // get an IQueryAble: to manipulate with deferred execution
        // GET: arts
        public virtual IQueryable<T> GetAll()
        {
            // Entities won't be manipulated directly on this set --> faster with AsNoTracking()
            return db.Set<T>().AsNoTracking();
        }


        public virtual async Task<IEnumerable<T>> ListAll()
        {
            return await GetAll().ToListAsync();
        }


        public virtual IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>()
                   .Where(predicate).AsNoTracking();
        }

        public virtual async Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }

        //POST: arts
        public virtual async Task<T> Add(T entity)
        {
            db.Set<T>().Add(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        public virtual async Task<T> Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        public virtual async Task<T> Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        public virtual async Task<T> Delete(long id)
        {
            var entity = await GetById(id);
            if (entity == null) return null;
            return await Delete(entity);
        }
    }
}
