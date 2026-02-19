using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticResponseDto
{
    [JsonPropertyName("data")]
    public BlingLogisticDto Data { get; set; } = null!;
}
