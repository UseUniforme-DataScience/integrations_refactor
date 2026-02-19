using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderUnidadeNegocioDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
