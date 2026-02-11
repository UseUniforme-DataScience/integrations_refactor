namespace Infrastructure.Http;

public class ShopifyOptions
{
    public const string SectionName = "Shopify";
    public string ApiKey { get; set; } = string.Empty;
    public string ApiVersion { get; set; } = "2024-01";
    public string StoreName { get; set; } = string.Empty;
    public string StoreUrl { get; set; } = string.Empty;
    public string BaseUrl => $"{StoreUrl.TrimEnd('/')}/admin/api/{ApiVersion}";
}
