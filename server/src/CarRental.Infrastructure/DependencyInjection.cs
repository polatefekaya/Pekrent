using System;
using CarRental.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure (this IServiceCollection services){
        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services, string? connectionString){
        if(connectionString is null) return services;
        
        services.AddDbContextPool<ApplicationDbContext>(
            options => options.UseNpgsql(connectionString)
        );
        return services;
    }
}
