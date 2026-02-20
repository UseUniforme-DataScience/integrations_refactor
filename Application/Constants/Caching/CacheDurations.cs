namespace Application.Constants.Caching;

public static class CacheDurations
{
    // Bling
    public static TimeSpan BlingToken { get; set; } = TimeSpan.FromHours(24);
    public static TimeSpan BlingOrder { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan BlingOrderSearch { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan BlingInvoice { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan BlingLogistic { get; set; } = TimeSpan.FromMinutes(15);

    // Shopify
    public static TimeSpan ShopifyCustomer { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan ShopifyCustomers { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan ShopifyOrder { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan ShopifyOrders { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan ShopifyProduct { get; set; } = TimeSpan.FromMinutes(15);
    public static TimeSpan ShopifyProducts { get; set; } = TimeSpan.FromMinutes(15);
}
