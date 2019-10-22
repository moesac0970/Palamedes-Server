﻿using G1_ee_groep1_palamedes.SH_MVL.API.Data;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;
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
        protected readonly ArtDataContext db;

        public Repository(ArtDataContext context)
        {
            db = context;
        }

        //GET: arts/{id}
        public virtual async Task<T> GetById(int id)
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


        public async Task<IEnumerable<T>> ListAll()
        {
            return await GetAll().ToListAsync();
        }


        public virtual IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>()
                   .Where(predicate).AsNoTracking();
        }

        public async virtual Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }

        //POST: arts
        public async Task<T> Add(T entity)
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

        public async Task<T> Update(T entity)
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

        public async Task<T> Delete(T entity)
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

        public async Task<T> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null) return null;
            return await Delete(entity);
        }
    }
}
