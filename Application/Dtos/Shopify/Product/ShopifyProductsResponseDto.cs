using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Product;

public class ShopifyProductsResponseDto
{
    [JsonPropertyName("products")]
    public List<ShopifyProductDto> Products { get; set; } = [];
}
