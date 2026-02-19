using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderComissaoDto
{
    [JsonPropertyName("base")]
    public decimal Base { get; set; }

    [JsonPropertyName("aliquota")]
    public decimal Aliquota { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}
