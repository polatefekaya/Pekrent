using System;
using CarRental.Application.Interfaces.Repository;
using Microsoft.Extensions.Logging;

namespace CarRental.Infrastructure.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly ILogger<GenericRepository<T>> _logger;

    public GenericRepository(ILogger<GenericRepository<T>> logger){
        _logger = logger;
    }
    public Task AddAsync(T entity)
    {
        _logger.LogInformation("AddAsync");
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
