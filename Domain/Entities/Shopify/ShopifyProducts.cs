namespace Domain.Entities.Shopify;

public class ShopifyProducts
{
    public long Id { get; set; }
    public string? Title { get; set; }
    public string? BodyHtml { get; set; }
    public string? Vendor { get; set; }
    public string? ProductType { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Handle { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public string? TemplateSuffix { get; set; }
    public string? PublishedScope { get; set; }
    public string? Tags { get; set; }
    public string? Status { get; set; }
    public string? AdminGraphqlApiId { get; set; }
    public string? Variants { get; set; }
    public string? Options { get; set; }
    public string? Images { get; set; }
    public string? Image { get; set; }
    public DateTime? InternalCreatedAt { get; set; }
    public DateTime? InternalUpdatedAt { get; set; }
}
