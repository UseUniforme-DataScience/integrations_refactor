namespace Domain.Entities;

public class SsotCustomers
{
    public required string Cpf { get; set; }
    public string? SsotCustomerId { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public bool? WhatsIsValid { get; set; }
    public DateTime? WhatsIsValidSearchDate { get; set; }
    public bool? AcceptMarketingEmail { get; set; }
    public bool? AcceptMarketingSms { get; set; }
    public bool? Blacklist { get; set; }
    public DateTime? BlacklistUpdatedAt { get; set; }
    public bool? DeletedOnKlaviyo { get; set; }
    public bool? DeletedOnPipedrive { get; set; }
    public string? CustomerType { get; set; }
    public bool? PurchaseIn21 { get; set; }
    public bool? PurchaseIn22 { get; set; }
    public bool? PurchaseIn23 { get; set; }
    public bool? PurchaseIn24 { get; set; }
    public bool? PurchaseIn25 { get; set; }
    public bool? PurchaseIn26 { get; set; }
    public DateTime? LastOrderDate { get; set; }
    public string? AddressLatitude { get; set; }
    public string? AddressLongitude { get; set; }
    public string? AddressStreet { get; set; }
    public string? AddressNumber { get; set; }
    public string? AddressComplement { get; set; }
    public string? AddressNeighborhood { get; set; }
    public string? AddressCity { get; set; }
    public string? AddressState { get; set; }
    public string? AddressCountry { get; set; }
    public string? AddressZipcode { get; set; }
    public long? ShopifyId { get; set; }
    public long? PipedriveId { get; set; }
    public string? KlaviyoId { get; set; }
    public bool? SyncKlaviyo { get; set; }
    public bool? SyncPipedrive { get; set; }
    public bool? SyncShopify { get; set; }
    public bool? IgnorePipedrive { get; set; }
    public bool? IgnoreKlaviyo { get; set; }
    public DateTime? UseCreatedAt { get; set; }
    public DateTime? UseUpdatedAt { get; set; }
}
