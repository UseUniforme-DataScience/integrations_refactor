using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Product;

public class ShopifyProductResponseDto
{
    [JsonPropertyName("product")]
    public required ShopifyProductDto Product { get; set; }
}
