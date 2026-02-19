using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderShippingLineDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("carrier_identifier")]
    public string? CarrierIdentifier { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("discounted_price")]
    public string? DiscountedPrice { get; set; }

    [JsonPropertyName("discounted_price_set")]
    public ShopifyOrderMoneySetDto? DiscountedPriceSet { get; set; }

    [JsonPropertyName("is_removed")]
    public bool? IsRemoved { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }

    [JsonPropertyName("price_set")]
    public ShopifyOrderMoneySetDto? PriceSet { get; set; }

    [JsonPropertyName("requested_fulfillment_service_id")]
    public long? RequestedFulfillmentServiceId { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("tax_lines")]
    public object? TaxLines { get; set; }

    [JsonPropertyName("discount_allocations")]
    public object? DiscountAllocations { get; set; }
}
