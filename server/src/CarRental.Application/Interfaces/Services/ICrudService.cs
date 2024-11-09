using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;
using CarRental.Domain.DTO;
using CarRental.Domain.Entities.Base;

namespace CarRental.Application.Interfaces.Services;

public interface ICrudService<T> where T : BaseEntity
{
    Task CreateAsync(AddGeneralDTO<T> dto);
    Task<T?> GetAsync(GetGeneralDTO dto);
    Task<IEnumerable<TResult>?> GetRangeAsync<TResult>(ISpecification<T, TResult> specification);
    Task<TResult?> GetFirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification);
    Task<TResult?> GetSingleOrDefaultAsync<TResult>(ISpecification<T, TResult> specification);
    Task<IEnumerable<T>?> GetAllAsync();
    Task UpdateAsync(UpdateGeneralDTO<T> dto);
    Task DeleteAsync(DeleteGeneralDTO dto);
    Task DeleteAsync(ISpecification<T, T> specification);
}
