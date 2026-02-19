using Application.Dtos.Pipedrive.Deal;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveDealClient
{
    // get deals by person
    Task<List<PipedriveDealListResponseDto>?> GetDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );

    // get deals by person with archived
    Task<List<PipedriveDealListResponseDto>?> GetDealsByPersonWithArchivedAsync(
        int personId,
        CancellationToken cancellationToken = default
    );

    // get open deals by person
    Task<List<PipedriveDealResponseDto>?> GetOpenDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    );

    // create deal
    Task<PipedriveDealResponseDto?> CreateDealAsync(
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    );

    // duplicate deal
    Task<PipedriveDealResponseDto?> DuplicateDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );

    //merge deals
    Task<PipedriveDealResponseDto?> MergeDealsAsync(
        int primaryDealId,
        int secondaryDealId,
        CancellationToken cancellationToken = default
    );

    // update deal
    Task<PipedriveDealResponseDto?> UpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    );

    // delete deal
    Task<bool> DeleteDealAsync(int dealId, CancellationToken cancellationToken = default);

    // get deal by id
    Task<PipedriveGetDealResponseDto?> GetDealByIdAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );

    // // create or update deal and delete others
    // Task<PipedriveDealResponseDto?> CreateOrUpdateDealAndDeleteOthersAsync(
    //     PipedriveDealRequestDto deal,
    //     CancellationToken cancellationToken = default
    // );

    // duplicate and update deal
    Task<PipedriveDealResponseDto?> DuplicateAndUpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    );
}
