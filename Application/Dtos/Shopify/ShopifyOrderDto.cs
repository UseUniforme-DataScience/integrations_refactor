using System.Text.Json.Serialization;

namespace Application.Dtos.Shopify;

public class ShopifyOrderResponseDto
{
    [JsonPropertyName("order")]
    public required ShopifyOrderDto Order { get; set; }
}

public class ShopifyOrderDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("app_id")]
    public long? AppId { get; set; }

    [JsonPropertyName("browser_ip")]
    public string? BrowserIp { get; set; }

    [JsonPropertyName("buyer_accepts_marketing")]
    public bool BuyerAcceptsMarketing { get; set; }

    [JsonPropertyName("cancel_reason")]
    public string? CancelReason { get; set; }

    [JsonPropertyName("cancelled_at")]
    public DateTime? CancelledAt { get; set; }

    [JsonPropertyName("cart_token")]
    public string? CartToken { get; set; }

    [JsonPropertyName("checkout_id")]
    public long? CheckoutId { get; set; }

    [JsonPropertyName("checkout_token")]
    public string? CheckoutToken { get; set; }

    [JsonPropertyName("client_details")]
    public ShopifyClientDetailsDto? ClientDetails { get; set; }

    [JsonPropertyName("closed_at")]
    public DateTime? ClosedAt { get; set; }

    [JsonPropertyName("confirmation_number")]
    public string? ConfirmationNumber { get; set; }

    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; }

    [JsonPropertyName("contact_email")]
    public string? ContactEmail { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("current_subtotal_price")]
    public string? CurrentSubtotalPrice { get; set; }

    [JsonPropertyName("current_subtotal_price_set")]
    public ShopifyMoneySetDto? CurrentSubtotalPriceSet { get; set; }

    [JsonPropertyName("current_total_additional_fees_set")]
    public ShopifyMoneySetDto? CurrentTotalAdditionalFeesSet { get; set; }

    [JsonPropertyName("current_total_discounts")]
    public string? CurrentTotalDiscounts { get; set; }

    [JsonPropertyName("current_total_discounts_set")]
    public ShopifyMoneySetDto? CurrentTotalDiscountsSet { get; set; }

    [JsonPropertyName("current_total_duties_set")]
    public ShopifyMoneySetDto? CurrentTotalDutiesSet { get; set; }

    [JsonPropertyName("current_total_price")]
    public string? CurrentTotalPrice { get; set; }

    [JsonPropertyName("current_total_price_set")]
    public ShopifyMoneySetDto? CurrentTotalPriceSet { get; set; }

    [JsonPropertyName("current_total_tax")]
    public string? CurrentTotalTax { get; set; }

    [JsonPropertyName("current_total_tax_set")]
    public ShopifyMoneySetDto? CurrentTotalTaxSet { get; set; }

    [JsonPropertyName("customer_locale")]
    public string? CustomerLocale { get; set; }

    [JsonPropertyName("device_id")]
    public long? DeviceId { get; set; }

    [JsonPropertyName("discount_codes")]
    public List<ShopifyDiscountCodeDto> DiscountCodes { get; set; } = [];

    [JsonPropertyName("duties_included")]
    public bool? DutiesIncluded { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("estimated_taxes")]
    public bool? EstimatedTaxes { get; set; }

    [JsonPropertyName("financial_status")]
    public string? FinancialStatus { get; set; }

    [JsonPropertyName("fulfillment_status")]
    public string? FulfillmentStatus { get; set; }

    [JsonPropertyName("landing_site")]
    public string? LandingSite { get; set; }

    [JsonPropertyName("landing_site_ref")]
    public string? LandingSiteRef { get; set; }

    [JsonPropertyName("location_id")]
    public long? LocationId { get; set; }

    [JsonPropertyName("merchant_business_entity_id")]
    public string? MerchantBusinessEntityId { get; set; }

    [JsonPropertyName("merchant_of_record_app_id")]
    public long? MerchantOfRecordAppId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("note_attributes")]
    public List<ShopifyNoteAttributeDto>? NoteAttributes { get; set; }

    [JsonPropertyName("number")]
    public long? Number { get; set; }

    [JsonPropertyName("order_number")]
    public long? OrderNumber { get; set; }

    [JsonPropertyName("order_status_url")]
    public string? OrderStatusUrl { get; set; }

    [JsonPropertyName("original_total_additional_fees_set")]
    public ShopifyMoneySetDto? OriginalTotalAdditionalFeesSet { get; set; }

    [JsonPropertyName("original_total_duties_set")]
    public ShopifyMoneySetDto? OriginalTotalDutiesSet { get; set; }

    [JsonPropertyName("payment_gateway_names")]
    public List<string>? PaymentGatewayNames { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("presentment_currency")]
    public string? PresentmentCurrency { get; set; }

    [JsonPropertyName("processed_at")]
    public DateTime ProcessedAt { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    [JsonPropertyName("referring_site")]
    public string? ReferringSite { get; set; }

    [JsonPropertyName("source_identifier")]
    public string? SourceIdentifier { get; set; }

    [JsonPropertyName("source_name")]
    public string? SourceName { get; set; }

    [JsonPropertyName("source_url")]
    public string? SourceUrl { get; set; }

    [JsonPropertyName("subtotal_price")]
    public string? SubtotalPrice { get; set; }

    [JsonPropertyName("subtotal_price_set")]
    public ShopifyMoneySetDto? SubtotalPriceSet { get; set; }

    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    [JsonPropertyName("tax_exempt")]
    public bool TaxExempt { get; set; }

    [JsonPropertyName("tax_lines")]
    public List<ShopifyTaxLineDto> TaxLines { get; set; } = [];

    [JsonPropertyName("taxes_included")]
    public bool TaxesIncluded { get; set; }

    [JsonPropertyName("test")]
    public bool Test { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }

    [JsonPropertyName("total_cash_rounding_payment_adjustment_set")]
    public ShopifyMoneySetDto? TotalCashRoundingPaymentAdjustmentSet { get; set; }

    [JsonPropertyName("total_cash_rounding_refund_adjustment_set")]
    public ShopifyMoneySetDto? TotalCashRoundingRefundAdjustmentSet { get; set; }

    [JsonPropertyName("total_discounts")]
    public string? TotalDiscounts { get; set; }

    [JsonPropertyName("total_discounts_set")]
    public ShopifyMoneySetDto? TotalDiscountsSet { get; set; }

    [JsonPropertyName("total_line_items_price")]
    public string? TotalLineItemsPrice { get; set; }

    [JsonPropertyName("total_line_items_price_set")]
    public ShopifyMoneySetDto? TotalLineItemsPriceSet { get; set; }

    [JsonPropertyName("total_outstanding")]
    public string? TotalOutstanding { get; set; }

    [JsonPropertyName("total_price")]
    public string? TotalPrice { get; set; }

    [JsonPropertyName("total_price_set")]
    public ShopifyMoneySetDto? TotalPriceSet { get; set; }

    [JsonPropertyName("total_shipping_price_set")]
    public ShopifyMoneySetDto? TotalShippingPriceSet { get; set; }

    [JsonPropertyName("total_tax")]
    public string? TotalTax { get; set; }

    [JsonPropertyName("total_tax_set")]
    public ShopifyMoneySetDto? TotalTaxSet { get; set; }

    [JsonPropertyName("total_tip_received")]
    public string? TotalTipReceived { get; set; }

    [JsonPropertyName("total_weight")]
    public long? TotalWeight { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }

    [JsonPropertyName("billing_address")]
    public ShopifyAddressDto? BillingAddress { get; set; }

    [JsonPropertyName("customer")]
    public ShopifyCustomerDto? Customer { get; set; }

    [JsonPropertyName("discount_applications")]
    public List<ShopifyDiscountApplicationDto>? DiscountApplications { get; set; }

    [JsonPropertyName("fulfillments")]
    public List<ShopifyFulfillmentDto>? Fulfillments { get; set; }

    [JsonPropertyName("line_items")]
    public List<ShopifyLineItemDto>? LineItems { get; set; }

    [JsonPropertyName("payment_terms")]
    public object? PaymentTerms { get; set; }

    [JsonPropertyName("refunds")]
    public object? Refunds { get; set; }

    [JsonPropertyName("shipping_address")]
    public ShopifyAddressDto? ShippingAddress { get; set; }

    [JsonPropertyName("shipping_lines")]
    public List<ShopifyShippingLineDto>? ShippingLines { get; set; }
}

public class ShopifyClientDetailsDto
{
    public string? AcceptLanguage { get; set; }
    public int? BrowserHeight { get; set; }
    public string? BrowserIp { get; set; }
    public int? BrowserWidth { get; set; }
    public string? SessionHash { get; set; }
    public string? UserAgent { get; set; }
}

public class ShopifyMoneySetDto
{
    public ShopifyMoneyDto? ShopMoney { get; set; }
    public ShopifyMoneyDto? PresentmentMoney { get; set; }
}

public class ShopifyMoneyDto
{
    public string? Amount { get; set; }
    public string? CurrencyCode { get; set; }
}

public class ShopifyDiscountCodeDto
{
    public string? Code { get; set; }
    public string? Amount { get; set; }
    public string? Type { get; set; }
}

public class ShopifyNoteAttributeDto
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}

public class ShopifyTaxLineDto
{
    public string? Title { get; set; }
    public string? Price { get; set; }
}

public class ShopifyAddressDto
{
    public string? FirstName { get; set; }
    public string? Address1 { get; set; }
    public string? Phone { get; set; }
    public string? City { get; set; }
    public string? Zip { get; set; }
    public string? Province { get; set; }
    public string? Country { get; set; }
    public string? LastName { get; set; }
    public string? Address2 { get; set; }
    public string? Company { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Name { get; set; }
    public string? CountryCode { get; set; }
    public string? ProvinceCode { get; set; }
}

public class ShopifyDiscountApplicationDto
{
    public string? TargetType { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }
    public string? ValueType { get; set; }
    public string? AllocationMethod { get; set; }
    public string? TargetSelection { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}

public class ShopifyFulfillmentDto
{
    public long Id { get; set; }
    public string? AdminGraphqlApiId { get; set; }
    public DateTime CreatedAt { get; set; }
    public long? LocationId { get; set; }
    public string? Name { get; set; }
    public long OrderId { get; set; }
    public object? OriginAddress { get; set; }
    public object? Receipt { get; set; }
    public string? Service { get; set; }
    public string? ShipmentStatus { get; set; }
    public string? Status { get; set; }
    public string? TrackingCompany { get; set; }
    public string? TrackingNumber { get; set; }
    public List<string>? TrackingNumbers { get; set; } = [];
    public string? TrackingUrl { get; set; }
    public List<string>? TrackingUrls { get; set; } = [];
    public DateTime UpdatedAt { get; set; }
    public List<ShopifyLineItemDto>? LineItems { get; set; } = [];
}

public class ShopifyLineItemDto
{
    public long Id { get; set; }
    public string? AdminGraphqlApiId { get; set; }
    public object? AttributedStaffs { get; set; }
    public int CurrentQuantity { get; set; }
    public int FulfillableQuantity { get; set; }
    public string? FulfillmentService { get; set; }
    public string? FulfillmentStatus { get; set; }
    public bool GiftCard { get; set; }
    public int Grams { get; set; }
    public string? Name { get; set; }
    public string? Price { get; set; }
    public ShopifyMoneySetDto? PriceSet { get; set; }
    public bool ProductExists { get; set; }
    public long ProductId { get; set; }
    public List<ShopifyPropertyDto>? Properties { get; set; } = [];
    public int Quantity { get; set; }
    public bool RequiresShipping { get; set; }
    public string? Sku { get; set; }
    public bool Taxable { get; set; }
    public string? Title { get; set; }
    public string? TotalDiscount { get; set; }
    public ShopifyMoneySetDto? TotalDiscountSet { get; set; }
    public long VariantId { get; set; }
    public string? VariantInventoryManagement { get; set; }
    public string? VariantTitle { get; set; }
    public string? Vendor { get; set; }
    public List<ShopifyTaxLineDto>? TaxLines { get; set; } = [];
    public object? Duties { get; set; }
    public List<ShopifyDiscountAllocationDto>? DiscountAllocations { get; set; } = [];
}

public class ShopifyPropertyDto
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}

public class ShopifyDiscountAllocationDto
{
    public string? Amount { get; set; }
    public ShopifyMoneySetDto? AmountSet { get; set; }
    public int DiscountApplicationIndex { get; set; }
}

public class ShopifyShippingLineDto
{
    public long Id { get; set; }
    public string? CarrierIdentifier { get; set; }
    public string? Code { get; set; }
    public string? DiscountedPrice { get; set; }
    public ShopifyMoneySetDto? DiscountedPriceSet { get; set; }
    public bool? IsRemoved { get; set; }
    public string? Phone { get; set; }
    public string? Price { get; set; }
    public ShopifyMoneySetDto? PriceSet { get; set; }
    public long? RequestedFulfillmentServiceId { get; set; }
    public string? Source { get; set; }
    public string? Title { get; set; }
    public object? TaxLines { get; set; }
    public object? DiscountAllocations { get; set; }
}
