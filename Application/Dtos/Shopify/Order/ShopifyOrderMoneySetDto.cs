using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Order;

public class ShopifyOrderMoneySetDto
{
    [JsonPropertyName("shop_money")]
    public ShopifyOrderMoneyDto? ShopMoney { get; set; }

    [JsonPropertyName("presentment_money")]
    public ShopifyOrderMoneyDto? PresentmentMoney { get; set; }
}
