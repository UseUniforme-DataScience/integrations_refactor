using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedriveMoneyValueDto
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
}
