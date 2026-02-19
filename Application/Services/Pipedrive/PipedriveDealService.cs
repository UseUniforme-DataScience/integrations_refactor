using Application.Dtos.Pipedrive.Deal;
using Application.Interfaces.Pipedrive;

namespace Application.Services.Pipedrive;

public class PipedriveDealService(IPipedriveDealClient dealClient) : IPipedriveDealService
{
    public async Task<PipedriveDealResponseDto?> GetDealByIdAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var response = await dealClient
            .GetDealByIdAsync(dealId, cancellationToken)
            .ConfigureAwait(false);
        return response?.Data;
    }

    public async Task<List<PipedriveDealListResponseDto>?> GetDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        return await dealClient
            .GetDealsByPersonAsync(personId, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<List<PipedriveDealListResponseDto>?> GetDealsByPersonWithArchivedAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) =>
        await dealClient
            .GetDealsByPersonWithArchivedAsync(personId, cancellationToken)
            .ConfigureAwait(false);

    public async Task<List<PipedriveDealResponseDto>?> GetOpenDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) =>
        await dealClient
            .GetOpenDealsByPersonAsync(personId, cancellationToken)
            .ConfigureAwait(false);

    public async Task<PipedriveDealResponseDto?> CreateDealAsync(
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    ) => await dealClient.CreateDealAsync(deal, cancellationToken).ConfigureAwait(false);

    public async Task<PipedriveDealResponseDto?> UpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    ) => await dealClient.UpdateDealAsync(dealId, deal, cancellationToken).ConfigureAwait(false);

    public async Task<bool> DeleteDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) => await dealClient.DeleteDealAsync(dealId, cancellationToken).ConfigureAwait(false);

    public async Task<PipedriveDealResponseDto?> DuplicateDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) => await dealClient.DuplicateDealAsync(dealId, cancellationToken).ConfigureAwait(false);

    public async Task<PipedriveDealResponseDto?> DuplicateAndUpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    ) =>
        await dealClient
            .DuplicateAndUpdateDealAsync(dealId, deal, cancellationToken)
            .ConfigureAwait(false);

    public async Task<PipedriveDealResponseDto?> MergeDealsAsync(
        int primaryDealId,
        int secondaryDealId,
        CancellationToken cancellationToken = default
    ) =>
        await dealClient
            .MergeDealsAsync(primaryDealId, secondaryDealId, cancellationToken)
            .ConfigureAwait(false);
}
