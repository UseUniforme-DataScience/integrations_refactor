using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderSearchLojaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("unidadeNegocio")]
    public BlingOrderSearchUnidadeNegocioDto UnidadeNegocio { get; set; } = null!;
}
