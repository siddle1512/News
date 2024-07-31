using Microsoft.EntityFrameworkCore;
using News.Domain.Common;
using News.Domain.Repositories;
using News.Infracstructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace News.Infracstructure.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : EntityBase
    {
        private readonly NewsDbContext _newsDbContext;

        public RepositoryBase(NewsDbContext newsDbContext)
        {
            _newsDbContext = newsDbContext;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _newsDbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _newsDbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _newsDbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            _newsDbContext.Set<T>().Add(entity);
            await _newsDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _newsDbContext.Entry(entity).State = EntityState.Modified;
            await _newsDbContext.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(T entity)
        {
            _newsDbContext.Set<T>().Remove(entity);
            await _newsDbContext.SaveChangesAsync();
        }
    }
}
