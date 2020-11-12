using Microsoft.EntityFrameworkCore;
using ServiceApp.Entities;
using ServiceApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Repositories
{
    public abstract class RepositoryBase<T, TContext> : IRepositoryBase<T> where T : class where TContext : DbContext
    {
        protected TContext ServiceAppQContext { get; set; }

        protected RepositoryBase(TContext ServiceQContext)
        {
            ServiceAppQContext = ServiceQContext;
        }
       

        public async Task<T> Create(T entity)
        {
            try
            {
                ServiceAppQContext.Set<T>().Add(entity);
                //await ServiceAppQContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Delete(int id)
        {
            try
            {
                var entity = await ServiceAppQContext.Set<T>().FindAsync(id);
                if (entity == null)
                {
                    return entity;
                }

                ServiceAppQContext.Set<T>().Remove(entity);
                await ServiceAppQContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public async Task<T> Get(int id)
        {
            try
            {
                return await ServiceAppQContext.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return await ServiceAppQContext.Set<T>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<List<T>> GetAllByCondition(Expression<Func<T, bool>> expression)
        {
            try
            {
                return ServiceAppQContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> Update(T entity)
        {
            try
            {
                ServiceAppQContext.Entry(entity).State = EntityState.Modified;
                await ServiceAppQContext.SaveChangesAsync();
                ServiceAppQContext.Entry(entity).State = EntityState.Detached;
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<T> Upload(T entity)
        {
            try
            {
                ServiceAppQContext.Entry(entity).State = EntityState.Modified;
                await ServiceAppQContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
