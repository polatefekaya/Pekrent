using System;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Infrastructure;

public static class DependencyInjection
{
        public static IServiceCollection AddInfrastructure (this IServiceCollection services){
        return services;
    }
}
