using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Note;

public class PipedriveNotesResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveNoteResponseDto> Data { get; set; } = [];

    [JsonPropertyName("additional_data")]
    public PipedriveAdditionalDataDto? AdditionalData { get; set; }
}
