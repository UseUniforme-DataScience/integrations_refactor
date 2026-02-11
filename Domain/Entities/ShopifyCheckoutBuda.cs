namespace Domain.Entities;

public class ShopifyCheckoutBuda
{
    public required long Id { get; set; }
    public int? Status { get; set; }
    public long? ShopifyOrderId { get; set; }
    public long? ShopifyOrderNumber { get; set; }
    public required string BudaCheckoutId { get; set; }
    public string? CartId { get; set; }
    public long? NsuHost { get; set; }
    public long? NsuAuth { get; set; }
    public string? SellerCode { get; set; }
    public bool? Reserve { get; set; }
    public string? PaymentOption { get; set; }
    public string? ShippingOption { get; set; }
    public string? CheckoutUrl { get; set; }
    public string? Name { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Document { get; set; }
    public string? LastCardDigits { get; set; }
    public int? BenefitType { get; set; }
    public float? RemainingBalance { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? TransactionDate { get; set; }
    public DateTime? LastTry { get; set; }
}
