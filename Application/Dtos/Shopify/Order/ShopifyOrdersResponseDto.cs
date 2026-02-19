using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrdersResponseDto
{
    [JsonPropertyName("orders")]
    public List<ShopifyOrderDto> Orders { get; set; } = [];
}
