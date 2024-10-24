using System;

namespace CarRental.Api;

public static class Swagger
{
    public static IServiceCollection ConfigureSwaggerGenData(this IServiceCollection services){
        services.AddSwaggerGen(options => {
            options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Version = "1.0", Title = "Car Rental API V1"});
            options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo { Version = "2.0", Title = "Car Rental API V2" });
        });
        return services;
    }
}
