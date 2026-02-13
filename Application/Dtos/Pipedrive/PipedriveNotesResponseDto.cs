using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedriveNotesResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveNoteResponseDto> Data { get; set; } = new();

    [JsonPropertyName("additional_data")]
    public PipedriveNoteAdditionalDataDto? AdditionalData { get; set; }
}

public class PipedriveNoteAdditionalDataDto
{
    [JsonPropertyName("pagination")]
    public PipedrivePaginationDto? Pagination { get; set; }
}
