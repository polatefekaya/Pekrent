using System;
using System.Linq.Expressions;
using CarRental.Domain.Entities.Base;

namespace CarRental.Application.Interfaces.Services;

public interface ICrudService<T> where T : BaseEntity
{
    Task CreateAsync(T entity);
    Task<T?> GetAsync(int id);
    Task<IEnumerable<T>?> GetRangeAsync(int[] ids);
     Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>?> GetAllAsync();
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task DeleteRangeAsync(int[] ids);
}
