using System;
using System.Linq.Expressions;

namespace CarRental.Application.Interfaces.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>?> GetRangeAsync(Expression<Func<T, bool>> predicate);
    Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>?> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteRangeAsync(T[] entities);
}
