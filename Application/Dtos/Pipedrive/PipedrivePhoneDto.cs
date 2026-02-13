using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedrivePhoneDto
{
    [JsonPropertyName("label")]
    public string Label { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;

    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
}
