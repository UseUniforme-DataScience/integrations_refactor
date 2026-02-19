using Application.Dtos.Shopify.Product;

namespace Application.Interfaces.Shopify;

public interface IShopifyProductService
{
    Task<ShopifyProductDto> GetProductByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    );
    Task<List<ShopifyProductDto>> GetProductsAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyProductDto> UpdateProductAsync(
        ShopifyProductRequestDto product,
        CancellationToken cancellationToken = default
    );
}
