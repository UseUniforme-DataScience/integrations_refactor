using Application.Dtos.Shopify;

namespace Application.Interfaces.Shopify;

public interface IShopifyProductService
{
    Task<ShopifyProductDto> GetProductByIdAsync(long id);
    Task<ShopifyProductDto> UpdateProductAsync(ShopifyProductDto product);
}
