using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticEmbalagemDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
