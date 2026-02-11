using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify;

public class ShopifyCustomerResponseDto
{
    [JsonPropertyName("customer")]
    public required ShopifyCustomerDto Customer { get; set; }
}

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
    public ShopifyEmailMarketingConsentDto? EmailMarketingConsent { get; set; }

    [JsonPropertyName("sms_marketing_consent")]
    public ShopifySmsMarketingConsentDto? SmsMarketingConsent { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("default_address")]
    public ShopifyCustomerAddressDto? DefaultAddress { get; set; }
}

public class ShopifyCustomerAddressDto
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("customer_id")]
    public long? CustomerId { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("company")]
    public string? Company { get; set; }

    [JsonPropertyName("address1")]
    public string? Address1 { get; set; }

    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("province")]
    public string? Province { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("zip")]
    public string? Zip { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("province_code")]
    public string? ProvinceCode { get; set; }

    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("country_name")]
    public string? CountryName { get; set; }

    [JsonPropertyName("default")]
    public bool? Default { get; set; }
}

public class ShopifyEmailMarketingConsentDto
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("opt_in_level")]
    public string? OptInLevel { get; set; }

    [JsonPropertyName("consent_updated_at")]
    public DateTime? ConsentUpdatedAt { get; set; }
}

public class ShopifySmsMarketingConsentDto
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("opt_in_level")]
    public string? OptInLevel { get; set; }

    [JsonPropertyName("consent_updated_at")]
    public DateTime? ConsentUpdatedAt { get; set; }

    [JsonPropertyName("consent_collected_from")]
    public string? ConsentCollectedFrom { get; set; }
}
