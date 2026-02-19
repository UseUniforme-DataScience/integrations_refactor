using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Product;

public class ShopifyProductImageDto
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("alt")]
    public string? Alt { get; set; }

    [JsonPropertyName("position")]
    public int? Position { get; set; }

    [JsonPropertyName("product_id")]
    public long? ProductId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("src")]
    public string? Src { get; set; }

    [JsonPropertyName("variant_ids")]
    public object? VariantIds { get; set; }
}
