using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;
using CarRental.Domain.Entities.Base;

namespace CarRental.Application.Interfaces.Services;

public interface ICrudService<T> where T : BaseEntity
{
    Task CreateAsync(T entity);
    Task<T?> GetAsync(int id);
    Task<IEnumerable<T>?> GetRangeAsync(ISpesification<T> spesification);
    Task<T?> GetFirstOrDefaultAsync(ISpesification<T> spesification);
    Task<T?> GetSingleOrDefaultAsync(ISpesification<T> spesification);
    Task<IEnumerable<T>?> GetAllAsync();
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task DeleteAsync(ISpesification<T> spesification);
}
