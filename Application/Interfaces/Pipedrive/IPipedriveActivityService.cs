using Application.Dtos.Pipedrive;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveActivityService
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
