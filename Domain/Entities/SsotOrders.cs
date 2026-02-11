namespace Domain.Entities;

public class SsotOrder
{
    public required long ShopifyOrderId { get; set; }
    public required long ShopifyOrderNumber { get; set; }
    public long? ShopifyCustomerId { get; set; }
    public string? SsotOrderId { get; set; }
    public string? Cpf { get; set; }
    public string? SellerCode { get; set; }
    public long? BlingOrderId { get; set; }
    public long? BlingOrderNumber { get; set; }
    public long? NfeId { get; set; }
    public long? NfeNumber { get; set; }
    public long? NfeSerie { get; set; }
    public string? NfeKey { get; set; }
    public string? BudaCheckoutId { get; set; }
    public long? NsuHost { get; set; }
    public long? NsuAuth { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? LogisticIds { get; set; }
    public string? TrackingCodes { get; set; }
    public string? State { get; set; }
    public string? Carrier { get; set; }
    public bool? Pdv { get; set; }
    public bool? OrderCancelled { get; set; }
    public DateTime? OrderCancelledAt { get; set; }
    public DateTime? OrderCreatedAt { get; set; }
    public DateTime? OrderDeliveredIn { get; set; }
    public DateTime? UseCreatedAt { get; set; }
    public DateTime? UseUpdatedAt { get; set; }
    public string? CartId { get; set; }
    public string? BenefitType { get; set; }
    public string? Origin { get; set; }
}
