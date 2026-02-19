using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderProdutoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
