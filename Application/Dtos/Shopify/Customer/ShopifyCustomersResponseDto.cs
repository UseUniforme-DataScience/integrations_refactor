using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Customer;

public class ShopifyCustomersResponseDto
{
    [JsonPropertyName("customers")]
    public List<ShopifyCustomerDto> Customers { get; set; } = [];
}
