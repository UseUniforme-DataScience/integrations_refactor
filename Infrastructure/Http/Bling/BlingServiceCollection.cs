using Application.Interfaces.Bling;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Http.Bling;

public static class BlingServiceCollection
{
    public const string BlingTokenHttpClientName = "BlingToken";

    public static IServiceCollection AddBlingTokenClient(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.Configure<BlingOptions>(configuration.GetSection(BlingOptions.SectionName));
        services.AddHttpClient(BlingTokenHttpClientName);
        services.AddSingleton<IBlingTokenClient, BlingTokenClient>();
        return services;
    }
}
