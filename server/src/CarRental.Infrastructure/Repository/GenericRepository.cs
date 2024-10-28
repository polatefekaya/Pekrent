using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Repository.Spesifications;
using CarRental.Application.Specifications.Base;
using CarRental.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CarRental.Infrastructure.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly ILogger<GenericRepository<T>> _logger;
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    private readonly string _className;

    public GenericRepository(ILogger<GenericRepository<T>> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
        _dbSet = _context.Set<T>();

        _className = $"GenericRepository for {typeof(T).Name}";
    }
    public async Task AddAsync(T entity)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(AddAsync), _className);

        await _dbSet.AddAsync(entity);

        await _context.SaveChangesAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(AddAsync), _className);
    }

    public async Task DeleteAsync(T entity)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteAsync), _className);

        _dbSet.Remove(entity);

        await _context.SaveChangesAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteAsync), _className);
    }

    public async Task DeleteRangeAsync(T[] entities)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteRangeAsync), _className);

        _dbSet.RemoveRange(entities);

        await _context.SaveChangesAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteRangeAsync), _className);
    }

    public async Task<IEnumerable<T>?> GetRangeAsync(Expression<Func<T, bool>> predicate)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetRangeAsync), _className);

        IEnumerable<T>? entities = null;

        entities = await _dbSet.Where(predicate).ToListAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetRangeAsync), _className);
        return entities;
    }

    public async Task<IEnumerable<T>?> GetAllAsync()
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetAllAsync), _className);

        IEnumerable<T>? entities = null;

        entities = await _dbSet.ToListAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetAllAsync), _className);
        return entities;
    }

    public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetFirstOrDefaultAsync), _className);

        T? entity = await _dbSet.FirstOrDefaultAsync(predicate);

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetFirstOrDefaultAsync), _className);
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(UpdateAsync), _className);

        _dbSet.Update(entity);

        await _context.SaveChangesAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(UpdateAsync), _className);
    }

    public async Task<IEnumerable<TResult>?> GetRangeAsync<TResult>(ISpecification<T, TResult> specification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetRangeAsync), _className);

        IEnumerable<TResult>? entities = null;

        IQueryable<TResult> query = SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), specification);

        entities = await query.ToListAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetRangeAsync), _className);

        return entities;
    }

    public async Task<TResult?> GetFirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetFirstOrDefaultAsync), _className);

        TResult? entity = default;

        IQueryable<TResult> query = SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), specification);

        entity = await query.FirstOrDefaultAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetFirstOrDefaultAsync), _className);

        return entity;
    }

    public async Task<TResult?> GetSingleOrDefaultAsync<TResult>(ISpecification<T, TResult> specification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(GetSingleOrDefaultAsync), _className);

        TResult? entity = default;

        specification.ApplySingleResult();

        IQueryable<TResult> query = SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), specification);

        entity = await query.SingleOrDefaultAsync();

        _logger.LogDebug("{methodName} finished in {className}", nameof(GetSingleOrDefaultAsync), _className);

        return entity;
    }

    public async Task DeleteAsync(ISpecification<T, T> specification)
    {
        _logger.LogInformation("{methodName} started in {className}", nameof(DeleteAsync), _className);

        IQueryable<T> query = SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), specification);

        IEnumerable<T> entitiesToDelete = await query.ToListAsync();

        _dbSet.RemoveRange(entitiesToDelete);

        _logger.LogDebug("{methodName} finished in {className}", nameof(DeleteAsync), _className);
    }
}
