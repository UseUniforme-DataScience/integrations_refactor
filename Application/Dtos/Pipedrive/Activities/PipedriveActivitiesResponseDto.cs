using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Activities;

public class PipedriveActivitiesResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveActivityDto> Data { get; set; } = [];

    [JsonPropertyName("additional_data")]
    public PipedriveAdditionalDataDto? AdditionalData { get; set; }
}
