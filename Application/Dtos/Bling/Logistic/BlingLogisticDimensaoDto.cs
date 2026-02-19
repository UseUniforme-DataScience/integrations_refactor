using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticDimensaoDto
{
    [JsonPropertyName("peso")]
    public decimal Peso { get; set; }

    [JsonPropertyName("altura")]
    public decimal Altura { get; set; }

    [JsonPropertyName("largura")]
    public decimal Largura { get; set; }

    [JsonPropertyName("comprimento")]
    public decimal Comprimento { get; set; }

    [JsonPropertyName("diametro")]
    public decimal Diametro { get; set; }
}
