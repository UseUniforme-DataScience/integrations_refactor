using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticRastreamentoDto
{
    [JsonPropertyName("codigo")]
    public string Codigo { get; set; } = null!;

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = null!;

    [JsonPropertyName("situacao")]
    public int Situacao { get; set; }

    [JsonPropertyName("origem")]
    public string Origem { get; set; } = null!;

    [JsonPropertyName("destino")]
    public string Destino { get; set; } = string.Empty;

    [JsonPropertyName("ultimaAlteracao")]
    public string UltimaAlteracao { get; set; } = null!;

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;
}
