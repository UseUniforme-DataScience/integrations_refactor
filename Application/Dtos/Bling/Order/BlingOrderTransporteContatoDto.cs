using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderTransporteContatoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;
}
