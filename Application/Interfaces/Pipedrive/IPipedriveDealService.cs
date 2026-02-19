using Application.Dtos.Pipedrive.Deal;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveDealService
{
    Task<PipedriveDealResponseDto?> GetDealByIdAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedriveDealListResponseDto>?> GetDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedriveDealListResponseDto>?> GetDealsByPersonWithArchivedAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedriveDealResponseDto>?> GetOpenDealsByPersonAsync(
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
