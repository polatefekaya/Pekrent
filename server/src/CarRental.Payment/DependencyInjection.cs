using System;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Payment;

public static class DependencyInjection
{
    public static IServiceCollection AddPayment(this IServiceCollection services){
        return services;
    }
}
