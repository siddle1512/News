using News.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace News.Domain.Repositories
{
    public interface IAsyncRepository<T> where T : EntityBase
    {
        public Task<IReadOnlyList<T>> GetAllAsync();
        public Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        public Task<T> GetByIdAsync(string id);
        public Task<T> AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
    }
}
