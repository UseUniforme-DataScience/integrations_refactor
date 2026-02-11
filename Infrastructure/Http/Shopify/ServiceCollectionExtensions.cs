using Application.Interfaces.Shopify;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Http.Shopify;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddShopifyClient(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.Configure<ShopifyOptions>(configuration.GetSection(ShopifyOptions.SectionName));
        services.AddHttpClient<IShopifyClient, ShopifyClient>();
        return services;
    }
}
