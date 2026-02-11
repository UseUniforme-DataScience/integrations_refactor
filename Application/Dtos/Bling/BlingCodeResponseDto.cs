using System.Text.Json.Serialization;

namespace Application.Dtos.Bling;

public class BlingCodeResponseDto
{
    [JsonPropertyName("access_code")]
    public string AccessCode { get; set; } = string.Empty;
}
