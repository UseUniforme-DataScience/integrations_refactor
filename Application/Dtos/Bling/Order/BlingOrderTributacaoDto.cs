using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderTributacaoDto
{
    [JsonPropertyName("totalICMS")]
    public decimal TotalICMS { get; set; }

    [JsonPropertyName("totalIPI")]
    public decimal TotalIPI { get; set; }
}
