using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Serilog;
using CarRental.Application;
using CarRental.Infrastructure;
using CarRental.Fines;
using CarRental.Payment;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration().CreateLogger();

builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration loggerConfiguration) => {
    loggerConfiguration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services);
});

builder.Services.AddHttpLogging(options => {
    options.LoggingFields = 
    Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestPropertiesAndHeaders 
    | Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.ResponsePropertiesAndHeaders;
});

builder.Services.AddApplication()
                .AddInfrastructure()
                .AddPayment()
                .AddFines();

builder.Services.AddControllers(options => {
    options.Filters.Add(new ProducesAttribute("application/json"));
    options.Filters.Add(new ConsumesAttribute("application/json"));
});

builder.Services.AddApiVersioning(config => {
    config.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version")
    ); 
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.ReportApiVersions = true;
})
    .AddVersionedApiExplorer(options => {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Version = "1.0", Title = "Car Rental API V1"});
    options.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo { Version = "2.0", Title = "Car Rental API V2" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "1.0");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "2.0");
});
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();