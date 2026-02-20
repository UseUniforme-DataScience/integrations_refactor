using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Shopify.Product;
using Application.Interfaces.Shopify;
using Domain.Interfaces;

namespace Application.Services.Shopify;

public class ShopifyProductService(IShopifyClient shopifyClient, IRedisService redisService)
    : IShopifyProductService
{
    public async Task<ShopifyProductDto?> GetProductByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var key = $"{ShopifyConstants.ShopifyProduct}:{id}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<ShopifyProductDto>(cached);
        }
        else
        {
            var product = await shopifyClient
                .GetProductAsync(id, cancellationToken)
                .ConfigureAwait(false);
            if (product is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(product),
                    CacheDurations.ShopifyProduct
                );
                return product;
            }
            return null;
        }
    }

    public async Task<List<ShopifyProductDto>?> GetProductsAsync(
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

        var key = $"{ShopifyConstants.ShopifyProducts}:{updatedBeforeString}:{updatedAfterString}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<List<ShopifyProductDto>>(cached);
        }
        else
        {
            var products = await shopifyClient
                .GetProductsAsync(updatedBeforeString, updatedAfterString, cancellationToken)
                .ConfigureAwait(false);
            if (products is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(products),
                    CacheDurations.ShopifyProducts
                );
                return products;
            }
            return null;
        }
    }

    public async Task<ShopifyProductDto?> UpdateProductAsync(
        ShopifyProductRequestDto product,
        CancellationToken cancellationToken = default
    )
    {
        var updated = await shopifyClient
            .PutProductAsync(product.Id, product, cancellationToken)
            .ConfigureAwait(false);
        return updated ?? throw new InvalidOperationException($"Product {product.Id} not found.");
    }
}
