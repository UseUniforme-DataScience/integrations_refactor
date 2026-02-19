using Application.Dtos.Pipedrive.Note;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveNoteClient
{
    Task<List<PipedriveNoteResponseDto>?> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    );

    Task<PipedriveNoteResponseDto?> CreateNoteAsync(
        PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    );
}
