using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Customer;

public class ShopifyCustomerResponseDto
{
    [JsonPropertyName("customer")]
    public required ShopifyCustomerDto Customer { get; set; }
}
