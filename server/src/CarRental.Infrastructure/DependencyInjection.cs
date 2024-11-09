using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Context;
using CarRental.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<SavedEntity>, GenericRepository<SavedEntity>>();
        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services, string? connectionString)
    {
        if (connectionString is null) return services;

        services.AddDbContextPool<ApplicationDbContext>(
            options =>
            {
                options.UseNpgsql(connectionString, o => o.UseNetTopologySuite());
            }
        );
        return services;
    }

    public static IServiceCollection ConfigureIdentity(this IServiceCollection services)
    {

        services.AddIdentity<UserEntity, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = true;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.User.RequireUniqueEmail = true;
        });

        return services;
    }
}
