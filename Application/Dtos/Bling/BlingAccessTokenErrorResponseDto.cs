using System.Text.Json.Serialization;

namespace Application.Dtos.Bling;

public class BlingAccessTokenErrorResponseDto
{
    [JsonPropertyName("error")]
    public BlingErrorDetailDto Error { get; set; } = null!;
}

public class BlingErrorDetailDto
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("message")]
    public string Message { get; set; } = null!;
}
