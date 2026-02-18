using Application.Interfaces.Pipedrive;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Http.Pipedrive;

public static class PipedriveServiceCollection
{
    public static IServiceCollection AddPipedriveDealClient(this IServiceCollection services)
    {
        services.AddHttpClient<IPipedriveDealClient, PipedriveDealClient>();
        return services;
    }

    public static IServiceCollection AddPipedriveActivityClient(this IServiceCollection services)
    {
        services.AddHttpClient<IPipedriveActivityClient, PipedriveActivityClient>();
        return services;
    }

    public static IServiceCollection AddPipedriveNoteClient(this IServiceCollection services)
    {
        services.AddHttpClient<IPipedriveNoteClient, PipedriveNoteClient>();
        return services;
    }

    public static IServiceCollection AddPipedrivePersonClient(this IServiceCollection services)
    {
        services.AddHttpClient<IPipedrivePersonClient, PipedrivePersonClient>();
        return services;
    }
}
