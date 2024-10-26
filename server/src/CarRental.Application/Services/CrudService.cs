using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services;
using CarRental.Domain.Entities.Base;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services;

public class CrudService<T> : ICrudService<T> where T : BaseEntity
{
    private readonly ILogger<CrudService<T>> _logger;
    private readonly IGenericRepository<T> _repository;
    private readonly string _className;
    public CrudService(ILogger<CrudService<T>> logger, IGenericRepository<T> repository){
        _logger = logger;
        _repository = repository;

        _className = $"CrudService for {typeof(T).Name}";
    }
    public async Task CreateAsync(T entity)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(CreateAsync), _className);
        _logger.LogTrace("Entity Id: {id}", entity.Id);
        await _repository.AddAsync(entity);
        _logger.LogDebug("{methodName} finished in {className}", nameof(CreateAsync), _className);
    }

    public async Task DeleteAsync(int id){
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteAsync), _className);
        _logger.LogTrace("Entity Id: {id}", id);
        T? entity = await _repository.GetFirstOrDefaultAsync(e => e.Id == id);
        if(entity is null){
            _logger.LogWarning("Entity was not found, returning");
            return;
        }
        await _repository.DeleteAsync(entity);
        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteAsync), _className);
    }

    public Task DeleteRangeAsync(int[] ids)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteRangeAsync), _className);
        _repository.GetRangeAsync
        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteRangeAsync), _className);
    }

    public Task<IEnumerable<T>?> GetAllAsync()
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetAllAsync), _className);
        
        _logger.LogDebug("{methodName} finished in {className}", nameof(GetAllAsync), _className);
    }

    public Task<T?> GetAsync(int id)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetAsync), _className);
        
        _logger.LogDebug("{methodName} finished in {className}", nameof(GetAsync), _className);
    }

    public Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetFirstOrDefaultAsync), _className);
        
        _logger.LogDebug("{methodName} finished in {className}", nameof(GetFirstOrDefaultAsync), _className);
    }

    public Task<IEnumerable<T>?> GetRangeAsync(int[] ids)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetRangeAsync), _className);
        
        _logger.LogDebug("{methodName} finished in {className}", nameof(GetRangeAsync), _className);
    }

    public Task UpdateAsync(T entity)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(UpdateAsync), _className);
        
        _logger.LogDebug("{methodName} finished in {className}", nameof(UpdateAsync), _className);
    }
}
