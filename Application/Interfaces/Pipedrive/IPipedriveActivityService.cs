using Application.Dtos.Pipedrive.Activities;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveActivityService
{
    Task<List<PipedriveActivityDto>?> GetActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedriveActivityDto>?> GetActivitiesFromPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<bool> DoneAllActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<bool> DoneActivityAsync(int activityId, CancellationToken cancellationToken = default);
}
