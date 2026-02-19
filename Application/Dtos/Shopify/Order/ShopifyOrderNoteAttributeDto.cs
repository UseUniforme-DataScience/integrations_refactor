using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderNoteAttributeDto
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
