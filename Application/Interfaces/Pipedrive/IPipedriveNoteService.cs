using Application.Dtos.Pipedrive.Note;

namespace Application.Interfaces.Pipedrive;

public interface IPipedriveNoteService
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
