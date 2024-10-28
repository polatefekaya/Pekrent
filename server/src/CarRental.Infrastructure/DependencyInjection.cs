using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Context;
using CarRental.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure (this IServiceCollection services){
        services.AddScoped<IGenericRepository<SavedEntity>, GenericRepository<SavedEntity>>();
        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services, string? connectionString){
        if(connectionString is null) return services;
        
        services.AddDbContextPool<ApplicationDbContext>(
            options => {
                options.UseNpgsql(connectionString, o => o.UseNetTopologySuite());
            }
        );
        return services;
    }
}
