namespace Domain.Entities.Shopify;

public class ShopifyCustomer
{
    public long Id { get; set; }
    public string? Cpf { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int OrdersCount { get; set; }
    public string? State { get; set; }
    public string? TotalSpent { get; set; }
    public long? LastOrderId { get; set; }
    public string? Note { get; set; }
    public bool VerifiedEmail { get; set; }
    public string? MultipassIdentifier { get; set; }
    public bool TaxExempt { get; set; }
    public string Tags { get; set; } = string.Empty;
    public string? LastOrderName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Currency { get; set; }
    public string? Addresses { get; set; }
    public string? TaxExemptions { get; set; }
    public string? EmailMarketingConsent { get; set; }
    public string? SmsMarketingConsent { get; set; }
    public string? AdminGraphqlApiId { get; set; }
    public string? DefaultAddress { get; set; }
    public DateTime? InternalCreatedAt { get; set; }
    public DateTime? InternalUpdatedAt { get; set; }
}
