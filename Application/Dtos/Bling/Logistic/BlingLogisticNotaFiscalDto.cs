using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticNotaFiscalDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
