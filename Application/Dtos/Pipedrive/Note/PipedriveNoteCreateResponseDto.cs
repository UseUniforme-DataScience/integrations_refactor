using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Note;

public class PipedriveNoteCreateResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public PipedriveNoteResponseDto? Data { get; set; }
}

public class PipedriveNoteAdditionalDataDto
{
    [JsonPropertyName("pagination")]
    public PipedrivePaginationDto? Pagination { get; set; }
}
