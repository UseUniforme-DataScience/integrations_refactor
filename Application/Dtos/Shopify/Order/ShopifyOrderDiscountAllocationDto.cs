using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderDiscountAllocationDto
{
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    [JsonPropertyName("amount_set")]
    public ShopifyOrderMoneySetDto? AmountSet { get; set; }

    [JsonPropertyName("discount_application_index")]
    public int DiscountApplicationIndex { get; set; }
}
