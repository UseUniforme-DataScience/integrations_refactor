using Application.Dtos.Pipedrive.Activities;
using Application.Interfaces.Pipedrive;

namespace Application.Services.Pipedrive;

public class PipedriveActivityService(IPipedriveActivityClient activityClient)
    : IPipedriveActivityService
{
    public async Task<List<PipedriveActivityDto>?> GetActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) =>
        await activityClient
            .GetActivitiesFromDealAsync(dealId, cancellationToken)
            .ConfigureAwait(false);

    public async Task<List<PipedriveActivityDto>?> GetActivitiesFromPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) =>
        await activityClient
            .GetActivitiesFromPersonAsync(personId, cancellationToken)
            .ConfigureAwait(false);

    public async Task<bool> DoneAllActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) =>
        await activityClient
            .DoneAllActivitiesFromDealAsync(dealId, cancellationToken)
            .ConfigureAwait(false);

    public async Task<bool> DoneActivityAsync(
        int activityId,
        CancellationToken cancellationToken = default
    ) =>
        await activityClient.DoneActivityAsync(activityId, cancellationToken).ConfigureAwait(false);
}
