using Application.Dtos.Pipedrive.Deal;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveDealService
{
    Task<PipedriveGetDealResponseDto?> GetDealByIdAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealsListResponseDto?> GetDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealsListResponseDto?> GetDealsByPersonWithArchivedAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealsResponseDto?> GetOpenDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealResponseDto?> CreateDealAsync(
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealResponseDto?> UpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    );
    Task<bool> DeleteDealAsync(int dealId, CancellationToken cancellationToken = default);
    Task<PipedriveDealResponseDto?> DuplicateDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealResponseDto?> DuplicateAndUpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    );
    Task<PipedriveDealResponseDto?> MergeDealsAsync(
        int primaryDealId,
        int secondaryDealId,
        CancellationToken cancellationToken = default
    );
}
