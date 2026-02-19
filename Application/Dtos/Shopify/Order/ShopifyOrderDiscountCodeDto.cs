using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderDiscountCodeDto
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
