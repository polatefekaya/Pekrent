using System;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Fines;

public static class DependencyInjection
{
    public static IServiceCollection AddFines (this IServiceCollection services){
        return services;
    }
}
