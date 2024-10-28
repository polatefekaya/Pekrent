using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;

namespace CarRental.Application.Interfaces.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>?> GetRangeAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<TResult>?> GetRangeAsync<TResult>(ISpecification<T, TResult> specification);
    Task<TResult?> GetFirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification);
    Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    Task<TResult?> GetSingleOrDefaultAsync<TResult>(ISpecification<T, TResult> specification);
    Task<IEnumerable<T>?> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteRangeAsync(T[] entities);
    Task DeleteAsync(ISpecification<T, T> specification);
}
