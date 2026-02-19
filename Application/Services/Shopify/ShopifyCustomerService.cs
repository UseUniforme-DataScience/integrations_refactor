using Application.Dtos.Shopify.Customer;
using Application.Interfaces.Shopify;

namespace Application.Services.Shopify;

public class ShopifyCustomerService(IShopifyClient shopifyClient) : IShopifyCustomerService
{
    public async Task<ShopifyCustomerDto> GetCustomerByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var customer = await shopifyClient
            .GetCustomerAsync(id, cancellationToken)
            .ConfigureAwait(false);
        return customer ?? throw new InvalidOperationException($"Customer {id} not found.");
    }

    public async Task<List<ShopifyCustomerDto>> GetCustomersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var customers = await shopifyClient
            .GetCustomersAsync(updatedBefore, updatedAfter, cancellationToken)
            .ConfigureAwait(false);
        return customers ?? [];
    }

    public async Task<ShopifyCustomerDto> UpdateCustomerAsync(
        long id,
        ShopifyCustomerRequestDto customer,
        CancellationToken cancellationToken = default
    )
    {
        var updated = await shopifyClient
            .PutCustomerAsync(id, customer, cancellationToken)
            .ConfigureAwait(false);
        return updated ?? throw new InvalidOperationException($"Customer {id} not found.");
    }
}
