using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderLineItemDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("attributed_staffs")]
    public object? AttributedStaffs { get; set; }

    [JsonPropertyName("current_quantity")]
    public int CurrentQuantity { get; set; }

    [JsonPropertyName("fulfillable_quantity")]
    public int FulfillableQuantity { get; set; }

    [JsonPropertyName("fulfillment_service")]
    public string? FulfillmentService { get; set; }

    [JsonPropertyName("fulfillment_status")]
    public string? FulfillmentStatus { get; set; }

    [JsonPropertyName("gift_card")]
    public bool GiftCard { get; set; }

    [JsonPropertyName("grams")]
    public int Grams { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }

    [JsonPropertyName("price_set")]
    public ShopifyOrderMoneySetDto? PriceSet { get; set; }

    [JsonPropertyName("product_exists")]
    public bool ProductExists { get; set; }

    [JsonPropertyName("product_id")]
    public long ProductId { get; set; }

    [JsonPropertyName("properties")]
    public List<ShopifyOrderPropertyDto>? Properties { get; set; } = [];

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("requires_shipping")]
    public bool RequiresShipping { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("taxable")]
    public bool Taxable { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("total_discount")]
    public string? TotalDiscount { get; set; }

    [JsonPropertyName("total_discount_set")]
    public ShopifyOrderMoneySetDto? TotalDiscountSet { get; set; }

    [JsonPropertyName("variant_id")]
    public long VariantId { get; set; }

    [JsonPropertyName("variant_inventory_management")]
    public string? VariantInventoryManagement { get; set; }

    [JsonPropertyName("variant_title")]
    public string? VariantTitle { get; set; }

    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }

    [JsonPropertyName("tax_lines")]
    public List<ShopifyOrderTaxLineDto>? TaxLines { get; set; } = [];

    [JsonPropertyName("duties")]
    public object? Duties { get; set; }

    [JsonPropertyName("discount_allocations")]
    public List<ShopifyOrderDiscountAllocationDto>? DiscountAllocations { get; set; } = [];
}
