using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Product;

public class ShopifyProductVariantDto
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("product_id")]
    public long? ProductId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }

    [JsonPropertyName("position")]
    public int? Position { get; set; }

    [JsonPropertyName("inventory_policy")]
    public string? InventoryPolicy { get; set; }

    [JsonPropertyName("compare_at_price")]
    public string? CompareAtPrice { get; set; }

    [JsonPropertyName("option1")]
    public string? Option1 { get; set; }

    [JsonPropertyName("option2")]
    public string? Option2 { get; set; }

    [JsonPropertyName("option3")]
    public string? Option3 { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("taxable")]
    public bool? Taxable { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    [JsonPropertyName("fulfillment_service")]
    public string? FulfillmentService { get; set; }

    [JsonPropertyName("grams")]
    public int? Grams { get; set; }

    [JsonPropertyName("inventory_management")]
    public string? InventoryManagement { get; set; }

    [JsonPropertyName("requires_shipping")]
    public bool? RequiresShipping { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("weight")]
    public double? Weight { get; set; }

    [JsonPropertyName("weight_unit")]
    public string? WeightUnit { get; set; }

    [JsonPropertyName("inventory_item_id")]
    public long? InventoryItemId { get; set; }

    [JsonPropertyName("inventory_quantity")]
    public int? InventoryQuantity { get; set; }

    [JsonPropertyName("old_inventory_quantity")]
    public int? OldInventoryQuantity { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("image_id")]
    public long? ImageId { get; set; }
}
