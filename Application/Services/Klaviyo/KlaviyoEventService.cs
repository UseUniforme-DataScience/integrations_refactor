using Application.Dtos.Klaviyo;
using Application.Interfaces.Klaviyo;

namespace Application.Services.Klaviyo;

public class KlaviyoEventService(IKlaviyoClient klaviyoClient) : IKlaviyoEventService
{
    public async Task SendEventAsync(
        KlaviyoEventRequestDto eventDto,
        CancellationToken cancellationToken = default
    )
    {
        await klaviyoClient.SendEventAsync(eventDto, cancellationToken).ConfigureAwait(false);
    }

    public async Task SendEventsInBulkAsync(
        IReadOnlyList<KlaviyoEventRequestDto> events,
        int batchSize = 500,
        int requestsIntervalSeconds = 10,
        CancellationToken cancellationToken = default
    )
    {
        await klaviyoClient
            .SendEventsInBulkAsync(events, batchSize, requestsIntervalSeconds, cancellationToken)
            .ConfigureAwait(false);
    }
}
