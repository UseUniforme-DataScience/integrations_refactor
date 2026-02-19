using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Product;

public class ShopifyProductOptionDto
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("product_id")]
    public long? ProductId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("position")]
    public int? Position { get; set; }

    [JsonPropertyName("values")]
    public object? Values { get; set; }
}
