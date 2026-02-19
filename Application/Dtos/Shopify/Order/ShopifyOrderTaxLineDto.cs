using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderTaxLineDto
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }
}
