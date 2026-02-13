using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

// response for default deals route
// /deals
public class PipedriveDealsResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveDealResponseDto> Data { get; set; } = [];

    [JsonPropertyName("additional_data")]
    public PipedriveDealAdditionalDataDto? AdditionalData { get; set; }
}
