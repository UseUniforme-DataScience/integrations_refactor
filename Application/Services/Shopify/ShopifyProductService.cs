using Application.Dtos.Shopify.Product;
using Application.Interfaces.Shopify;

namespace Application.Services.Shopify;

public class ShopifyProductService(IShopifyClient shopifyClient) : IShopifyProductService
{
    public async Task<ShopifyProductDto> GetProductByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var product = await shopifyClient
            .GetProductAsync(id, cancellationToken)
            .ConfigureAwait(false);
        return product ?? throw new InvalidOperationException($"Product {id} not found.");
    }

    public async Task<ShopifyProductDto> UpdateProductAsync(
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
