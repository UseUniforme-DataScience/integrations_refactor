using Application.Dtos.Pipedrive.Note;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveNoteClient
{
    Task<PipedriveNotesResponseDto?> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );

    Task<PipedriveNoteCreateResponseDto?> CreateNoteAsync(
        PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    );
}
