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

    public static IApplicationBuilder ConfigureSwaggerMiddlewares(this IApplicationBuilder app){
        app.UseSwagger();
        app.UseSwaggerUI(options => {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "1.0");
            options.SwaggerEndpoint("/swagger/v2/swagger.json", "2.0");
        });
        return app;
    }
}
