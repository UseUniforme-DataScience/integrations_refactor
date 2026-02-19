using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderVolumeDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("servico")]
    public string Servico { get; set; } = null!;

    [JsonPropertyName("codigoRastreamento")]
    public string CodigoRastreamento { get; set; } = null!;
}
