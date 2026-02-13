using Application.Dtos.Pipedrive;
using Application.Interfaces.Pipedrive;

namespace Application.Services.Pipedrive;

public class PipedriveNoteService(IPipedriveNoteClient noteClient) : IPipedriveNoteService
{
    public async Task<PipedriveNotesResponseDto?> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) => await noteClient.GetNotesFromDealAsync(dealId, cancellationToken).ConfigureAwait(false);

    public async Task<PipedriveNoteResponseDto?> CreateNoteAsync(
        PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    ) => await noteClient.CreateNoteAsync(note, cancellationToken).ConfigureAwait(false);
}
