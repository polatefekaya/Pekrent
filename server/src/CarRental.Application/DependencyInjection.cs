using System;
using CarRental.Application.Interfaces.Services;
using CarRental.Application.Interfaces.Services.Availability;
using CarRental.Application.Interfaces.Services.Save;
using CarRental.Application.Services;
using CarRental.Application.Services.Availability;
using CarRental.Application.Services.Save;
using CarRental.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services){

        
        services.AddScoped<ISaveService, SaveService>();
        return services;
    }
}
