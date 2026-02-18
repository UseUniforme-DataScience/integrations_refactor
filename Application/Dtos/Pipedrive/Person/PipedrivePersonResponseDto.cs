using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Person;

public class PipedrivePersonResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public PipedrivePersonDataDto? Data { get; set; }
}
