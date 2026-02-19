using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify.Customer;

public class ShopifyCustomerDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("orders_count")]
    public int OrdersCount { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("total_spent")]
    public string? TotalSpent { get; set; }

    [JsonPropertyName("last_order_id")]
    public long? LastOrderId { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("verified_email")]
    public bool VerifiedEmail { get; set; }

    [JsonPropertyName("multipass_identifier")]
    public string? MultipassIdentifier { get; set; }

    [JsonPropertyName("tax_exempt")]
    public bool TaxExempt { get; set; }

    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    [JsonPropertyName("last_order_name")]
    public string? LastOrderName { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("addresses")]
    public List<ShopifyCustomerAddressDto>? Addresses { get; set; }

    [JsonPropertyName("tax_exemptions")]
    public object? TaxExemptions { get; set; }

    [JsonPropertyName("email_marketing_consent")]
    public ShopifyMarketingConsentDto? EmailMarketingConsent { get; set; }

    [JsonPropertyName("sms_marketing_consent")]
    public ShopifyMarketingConsentDto? SmsMarketingConsent { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("default_address")]
    public ShopifyCustomerAddressDto? DefaultAddress { get; set; }
}
