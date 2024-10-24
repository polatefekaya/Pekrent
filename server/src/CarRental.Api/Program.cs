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
                .AddDatabase(builder.Configuration.GetConnectionString(""))
                .AddInfrastructure()
                .AddPayment()
                .AddFines();

builder.Services.AddControllers(options => {
    options.Filters.Add(new ProducesAttribute("application/json"));
    options.Filters.Add(new ConsumesAttribute("application/json"));
});

builder.Services.ConfigureApiVersioning();

builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwaggerGenData();

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