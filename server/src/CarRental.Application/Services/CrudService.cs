using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Repository.Spesifications;
using CarRental.Application.Interfaces.Services;
using CarRental.Application.Spesifications.Base;
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

        try {
            await _repository.AddAsync(entity);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetAsync), _className);
            _logger.LogTrace("Id: {id}", entity.Id);

            return;
        }
        
        _logger.LogDebug("{methodName} finished in {className}", nameof(CreateAsync), _className);
    }

    public async Task DeleteAsync(int id){
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteAsync), _className);

        try {
            T? entity = await _repository.GetFirstOrDefaultAsync(e => e.Id == id);
            
            if(entity is null){
                throw new ArgumentNullException("Entity was not found");
            }

            await _repository.DeleteAsync(entity);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetAsync), _className);
            _logger.LogTrace("Id: {id}",id);

            return;
        }

        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteAsync), _className);
    }

    public async Task DeleteAsync(ISpesification<T> spesification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteAsync), _className);

        try {
            await _repository.DeleteAsync(spesification);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetAsync), _className);
            _logger.LogTrace("Criteria: {criteria}", spesification.Criteria);

            return;
        }

        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteAsync), _className);
    }


    public async Task<IEnumerable<T>?> GetAllAsync()
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetAllAsync), _className);

        IEnumerable<T>? entities = null;

        try {
            entities = await _repository.GetAllAsync();
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetAllAsync), _className);

            return entities;
        }

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetAllAsync), _className);
        return entities;
    }

    public async Task<T?> GetAsync(int id)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetAsync), _className);
        
        T? entity = null;

        try {
            entity = await _repository.GetFirstOrDefaultAsync(e => e.Id == id);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetAsync), _className);
            _logger.LogTrace("Id: {id}",id);

            return entity;
        }

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetAsync), _className);
        return entity;
    }


    public async Task<T?> GetFirstOrDefaultAsync(ISpesification<T> spesification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetFirstOrDefaultAsync), _className);

        T? entity = null;

        try {
            entity = await _repository.GetFirstOrDefaultAsync(spesification);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetFirstOrDefaultAsync), _className);
            _logger.LogTrace("Criteria: {criteria}", spesification.Criteria);

            return entity;
        }

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetFirstOrDefaultAsync), _className);

        return entity;
    }

    public async Task<IEnumerable<T>?> GetRangeAsync(ISpesification<T> spesification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetRangeAsync), _className);

        IEnumerable<T>? entities = null;

        try {
            entities = await _repository.GetRangeAsync(spesification);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetRangeAsync), _className);
            _logger.LogTrace("Criteria: {criteria}", spesification.Criteria);

            return entities;
        }

        _logger.LogInformation("{methodName} finished in {className}", nameof(GetRangeAsync), _className);

        return entities;
    }

    public async Task<T?> GetSingleOrDefaultAsync(ISpesification<T> spesification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetSingleOrDefaultAsync), _className);

        T? entity = null;

        try {
            entity = await _repository.GetSingleOrDefaultAsync(spesification);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(GetSingleOrDefaultAsync), _className);
            _logger.LogTrace("Criteria: {criteria}", spesification.Criteria);

            return entity;
        }

        _logger.LogInformation("{methodName} finished in {className}", nameof(GetSingleOrDefaultAsync), _className);

        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(UpdateAsync), _className);

        try {
            await _repository.UpdateAsync(entity);
        }
        catch (Exception ex){
            _logger.LogError(ex, "Something unexpected happened while executing {methodName} in {className}", nameof(UpdateAsync), _className);
            _logger.LogTrace("Id: {id}", entity.Id);

            return;
        }

        _logger.LogDebug("{methodName} finished in {className}", nameof(UpdateAsync), _className);
    }
}
