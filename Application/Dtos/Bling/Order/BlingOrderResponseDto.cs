using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderResponseDto
{
    [JsonPropertyName("data")]
    public BlingOrderDto Data { get; set; } = null!;
}
