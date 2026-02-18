using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Deal;

public class PipedriveGetDealResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public PipedriveDealResponseDto? Data { get; set; }
}
