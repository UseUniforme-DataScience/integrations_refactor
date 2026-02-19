using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderDescontoDto
{
    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("unidade")]
    public string Unidade { get; set; } = null!;
}
