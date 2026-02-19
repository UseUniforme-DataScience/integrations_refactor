using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderSituacaoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}
