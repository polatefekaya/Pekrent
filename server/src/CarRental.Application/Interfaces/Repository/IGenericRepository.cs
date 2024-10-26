using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;

namespace CarRental.Application.Interfaces.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>?> GetRangeAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>?> GetRangeAsync(ISpesification<T> spesification);
    Task<T?> GetFirstOrDefaultAsync(ISpesification<T> spesification);
    Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    Task<T?> GetSingleOrDefaultAsync(ISpesification<T> spesification);
    Task<IEnumerable<T>?> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task DeleteRangeAsync(T[] entities);
    Task DeleteAsync(ISpesification<T> spesification);
}
