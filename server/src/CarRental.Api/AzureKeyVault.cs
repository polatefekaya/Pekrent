using System;
using Azure.Identity;

namespace CarRental.Api;

public static class AzureKeyVault
{
    public static IConfigurationBuilder ConfigureAzureKeyVault(this IConfigurationBuilder configuration, string? keyVaultName){
        if (keyVaultName is null) return configuration;

        Uri keyVaultUri = new Uri($"https://{keyVaultName}.vault.azure.net/");

        configuration.AddAzureKeyVault(keyVaultUri, new DefaultAzureCredential());
        return configuration;
    }
}
