using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedriveAdditionalDataDto
{
    [JsonPropertyName("pagination")]
    public PipedrivePaginationDto? Pagination { get; set; }

    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; set; }
}
