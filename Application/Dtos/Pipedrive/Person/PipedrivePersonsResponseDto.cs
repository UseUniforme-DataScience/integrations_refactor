using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Person;

public class PipedrivePersonsResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedrivePersonDataDto> Data { get; set; } = [];
}
