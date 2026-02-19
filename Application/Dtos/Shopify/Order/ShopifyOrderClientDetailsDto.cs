using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderClientDetailsDto
{
    [JsonPropertyName("accept_language")]
    public string? AcceptLanguage { get; set; }

    [JsonPropertyName("browser_height")]
    public int? BrowserHeight { get; set; }

    [JsonPropertyName("browser_ip")]
    public string? BrowserIp { get; set; }

    [JsonPropertyName("browser_width")]
    public int? BrowserWidth { get; set; }

    [JsonPropertyName("session_hash")]
    public string? SessionHash { get; set; }

    [JsonPropertyName("user_agent")]
    public string? UserAgent { get; set; }
}
