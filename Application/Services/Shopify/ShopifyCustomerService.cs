using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Shopify.Customer;
using Application.Interfaces.Shopify;
using Domain.Interfaces;

namespace Application.Services.Shopify;

public class ShopifyCustomerService(IShopifyClient shopifyClient, IRedisService redisService)
    : IShopifyCustomerService
{
    public async Task<ShopifyCustomerDto?> GetCustomerByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var key = $"{ShopifyConstants.ShopifyCustomer}:{id}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<ShopifyCustomerDto>(cached);
        }
        else
        {
            var customer = await shopifyClient
                .GetCustomerAsync(id, cancellationToken)
                .ConfigureAwait(false);
            if (customer is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(customer),
                    CacheDurations.ShopifyCustomer
                );
                return customer;
            }
            return null;
        }
    }

    public async Task<List<ShopifyCustomerDto>?> GetCustomersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var updatedBeforeString = updatedBefore is not null
            ? updatedBefore.Value.ToUniversalTime()
            : DateTime.Now.AddDays(-7).ToUniversalTime();
        var updatedAfterString = updatedAfter is not null
            ? updatedAfter.Value.ToUniversalTime()
            : DateTime.Now.ToUniversalTime();

        var key = $"{ShopifyConstants.ShopifyCustomers}:{updatedBeforeString}:{updatedAfterString}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<List<ShopifyCustomerDto>>(cached);
        }
        else
        {
            var customers = await shopifyClient
                .GetCustomersAsync(updatedBeforeString, updatedAfterString, cancellationToken)
                .ConfigureAwait(false);
            if (customers is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(customers),
                    CacheDurations.ShopifyCustomers
                );
                return customers;
            }
            return null;
        }
    }

    public async Task<ShopifyCustomerDto?> UpdateCustomerAsync(
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
