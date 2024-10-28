using System;
using Azure.Monitor.OpenTelemetry.Exporter;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace CarRental.Api;

public static class OpenTelemetry
{
    public static IServiceCollection ConfigureOpenTelemetry(this IServiceCollection services, string serviceName, string? connectionString){
        if(connectionString is null) return services;

        services.AddApplicationInsightsTelemetry(opts => {
            opts.ConnectionString = connectionString;
        });

        services.AddOpenTelemetry()
                .ConfigureResource(res => res.AddService(serviceName))
                .WithMetrics(metrics => metrics
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddAzureMonitorMetricExporter(opts => {
                        opts.ConnectionString = connectionString;
                    }))
                .WithTracing(tracing => tracing
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddSqlClientInstrumentation()
                    .AddAzureMonitorTraceExporter(opts => {
                        opts.ConnectionString = connectionString;
                    }));
        return services;
    }
}
