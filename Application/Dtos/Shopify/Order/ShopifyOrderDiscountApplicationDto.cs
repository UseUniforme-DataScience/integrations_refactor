using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderDiscountApplicationDto
{
    [JsonPropertyName("target_type")]
    public string? TargetType { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("value_type")]
    public string? ValueType { get; set; }

    [JsonPropertyName("allocation_method")]
    public string? AllocationMethod { get; set; }

    [JsonPropertyName("target_selection")]
    public string? TargetSelection { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
