using Application.Dtos.Shopify;
using Application.Interfaces.Shopify;

namespace Application.Services.Shopify;

public class ShopifyCustomerService(IShopifyClient shopifyClient) : IShopifyCustomerService
{
    public async Task<ShopifyCustomerDto> GetCustomerByIdAsync(long id)
    {
        var customer = await shopifyClient.GetCustomerAsync(id).ConfigureAwait(false);
        return customer ?? throw new InvalidOperationException($"Customer {id} not found.");
    }

    public async Task<ShopifyCustomerDto> UpdateCustomerAsync(long id, ShopifyCustomerDto customer)
    {
        var updated = await shopifyClient.PutCustomerAsync(id, customer).ConfigureAwait(false);
        return updated ?? throw new InvalidOperationException($"Customer {id} not found.");
    }
}
