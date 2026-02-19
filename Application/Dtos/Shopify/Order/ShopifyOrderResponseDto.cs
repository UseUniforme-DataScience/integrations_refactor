using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderResponseDto
{
    [JsonPropertyName("order")]
    public required ShopifyOrderDto Order { get; set; }
}
