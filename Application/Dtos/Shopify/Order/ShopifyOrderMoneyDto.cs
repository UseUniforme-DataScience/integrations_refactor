using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderMoneyDto
{
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }
}
