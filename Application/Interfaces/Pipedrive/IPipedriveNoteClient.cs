using Application.Dtos.Pipedrive;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveNoteClient
{
    Task<PipedriveNotesResponseDto?> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );

    Task<PipedriveNoteResponseDto?> CreateNoteAsync(
        PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    );
}
