using Application.Dtos.Shopify;
using Application.Interfaces.Shopify;

namespace Application.Services.Shopify;

public class ShopifyProductService(IShopifyClient shopifyClient) : IShopifyProductService
{
    public async Task<ShopifyProductDto> GetProductByIdAsync(long id)
    {
        var product = await shopifyClient.GetProductAsync(id).ConfigureAwait(false);
        return product ?? throw new InvalidOperationException($"Product {id} not found.");
    }

    public async Task<ShopifyProductDto> UpdateProductAsync(ShopifyProductDto product)
    {
        var updated = await shopifyClient
            .PutProductAsync(product.Id, product)
            .ConfigureAwait(false);
        return updated ?? throw new InvalidOperationException($"Product {product.Id} not found.");
    }
}
