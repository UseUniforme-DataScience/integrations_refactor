using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderFormaPagamentoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
