using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Constants;

public static class ShopifyConstants
{
    public static string ShopifyCustomer { get; set; } = "shopify:customer";
    public static string ShopifyCustomers { get; set; } = "shopify:customers";
    public static string ShopifyOrder { get; set; } = "shopify:order";
    public static string ShopifyOrders { get; set; } = "shopify:orders";
    public static string ShopifyProduct { get; set; } = "shopify:product";
    public static string ShopifyProducts { get; set; } = "shopify:products";
}
