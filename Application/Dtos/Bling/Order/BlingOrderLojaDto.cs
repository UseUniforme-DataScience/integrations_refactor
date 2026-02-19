using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderLojaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("unidadeNegocio")]
    public BlingOrderUnidadeNegocioDto UnidadeNegocio { get; set; } = null!;
}
