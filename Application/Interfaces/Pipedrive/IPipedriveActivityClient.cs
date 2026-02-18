using Application.Dtos.Pipedrive.Activities;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveActivityClient
{
    Task<PipedriveActivitiesResponseDto?> GetActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveActivitiesResponseDto?> GetActivitiesFromPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<bool> DoneAllActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<bool> DoneActivityAsync(int activityId, CancellationToken cancellationToken = default);
}
