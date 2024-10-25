using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Serilog;
using CarRental.Application;
using CarRental.Infrastructure;
using CarRental.Fines;
using CarRental.Payment;
using CarRental.Api;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration().CreateLogger();

builder.Host.ConfigureCustomSerilog();

builder.Services.ConfigureCustomLogging();

builder.Services.AddApplication()
                //.AddDatabase(builder.Configuration.GetConnectionString(""))
                .AddInfrastructure()
                .AddPayment()
                .AddFines();

builder.Services.AddControllers(options => {
    options.Filters.Add(new ProducesAttribute("application/json"));
    options.Filters.Add(new ConsumesAttribute("application/json"));
});
//Telemetry, use Azure Key Vault
//builder.Services.ConfigureOpenTelemetry("car-rental-api", builder.Configuration.GetConnectionString(""));

builder.Services.ConfigureApiVersioning();

builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwaggerGenData();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.ConfigureSwaggerMiddlewares();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();