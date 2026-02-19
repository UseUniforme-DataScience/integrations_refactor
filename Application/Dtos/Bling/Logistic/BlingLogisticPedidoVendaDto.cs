using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticPedidoVendaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
