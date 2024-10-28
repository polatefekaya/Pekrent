using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;
using CarRental.Domain.Entities.Base;

namespace CarRental.Application.Interfaces.Services;

public interface ICrudService<T> where T : BaseEntity
{
    Task CreateAsync(T entity);
    Task<T?> GetAsync(int id);
    Task<IEnumerable<TResult>?> GetRangeAsync<TResult>(ISpecification<T, TResult> specification);
    Task<TResult?> GetFirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification);
    Task<TResult?> GetSingleOrDefaultAsync<TResult>(ISpecification<T, TResult> specification);
    Task<IEnumerable<T>?> GetAllAsync();
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task DeleteAsync(ISpecification<T, T> specification);
}
