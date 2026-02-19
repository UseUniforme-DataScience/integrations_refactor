using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderSearchResponseDto
{
    [JsonPropertyName("data")]
    public List<BlingOrderSearchDto> Data { get; set; } = [];
}
