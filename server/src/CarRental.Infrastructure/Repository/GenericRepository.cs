using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository;
using CarRental.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CarRental.Infrastructure.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly ILogger<GenericRepository<T>> _logger;
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ILogger<GenericRepository<T>> logger, ApplicationDbContext context){
        _logger = logger;
        _context = context;
        _dbSet = _context.Set<T>();
    }
    public async Task AddAsync(T entity)
    {
        _logger.LogInformation("AddAsync started for {type}", typeof(T));
        // await _dbSet.AddAsync(entity);
        // await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _logger.LogInformation("DeleteAsync started for {type}", typeof(T));
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRangeAsync(T[] entities){
        _logger.LogInformation("DeleteAllAsync started for {type}", typeof(T));
        _dbSet.RemoveRange(entities);
        await _context.SaveChangesAsync();  
    }

    public async Task<IEnumerable<T>?> GetRangeAsync(Expression<Func<T, bool>> predicate){
        _logger.LogInformation("GetAllAsync started for {type}", typeof(T));
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public async Task<IEnumerable<T>?> GetAllAsync(){
        _logger.LogInformation("GetAllAsync started for {type}", typeof(T));
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate){
        _logger.LogInformation("GetFirstOrDefaultAsync started for {type}", typeof(T));
        return await _dbSet.FirstOrDefaultAsync(predicate);
    }

    public async Task UpdateAsync(T entity)
    {
        _logger.LogInformation("UpdateAsync started for {type}", typeof(T));
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

}
