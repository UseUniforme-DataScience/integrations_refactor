using Application.Interfaces.Klaviyo;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Http.Klaviyo;

public static class KlaviyoServiceCollection
{
    public static IServiceCollection AddKlaviyoClient(this IServiceCollection services)
    {
        services.AddHttpClient<IKlaviyoClient, KlaviyoClient>();
        return services;
    }
}
