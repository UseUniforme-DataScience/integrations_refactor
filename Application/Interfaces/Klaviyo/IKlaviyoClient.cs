using Application.Dtos.Klaviyo;

namespace Application.Interfaces.Klaviyo;

public interface IKlaviyoClient
{
    Task<bool> SendEventAsync(
        KlaviyoEventRequestDto eventDto,
        CancellationToken cancellationToken = default
    );

    Task SendEventsInBulkAsync(
        IReadOnlyList<KlaviyoEventRequestDto> events,
        int batchSize = 500,
        int requestsIntervalSeconds = 10,
        CancellationToken cancellationToken = default
    );
}
