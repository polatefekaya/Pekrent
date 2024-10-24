using System;
using CarRental.Application.Interfaces.Repository;

namespace CarRental.Infrastructure.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAllAsync(){
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
