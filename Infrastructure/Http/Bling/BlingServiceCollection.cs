using Application.Interfaces.Bling;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Http.Bling;

public static class BlingServiceCollection
{
    public const string BlingTokenHttpClientName = "BlingToken";

    public static IServiceCollection AddBlingTokenClient(this IServiceCollection services)
    {
        services.AddHttpClient(BlingTokenHttpClientName);
        services.AddSingleton<IBlingTokenClient, BlingTokenClient>();
        return services;
    }

    public static IServiceCollection AddBlingClient(this IServiceCollection services)
    {
        services.AddHttpClient<IBlingClient, BlingClient>();
        return services;
    }
}
