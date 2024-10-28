using System;
using Serilog;

namespace CarRental.Api;

public static class Logging
{
    public static IHostBuilder ConfigureCustomSerilog(this IHostBuilder host){
        host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration loggerConfiguration) => {
            loggerConfiguration
            .ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services);
        });
        return host;
    }
    public static IServiceCollection ConfigureCustomLogging(this IServiceCollection services){
        services.AddHttpLogging(options => {
            options.LoggingFields = 
            Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestPropertiesAndHeaders 
            | Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.ResponsePropertiesAndHeaders;
        });
        return services;
    }
}
