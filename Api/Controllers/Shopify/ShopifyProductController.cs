using Application.Dtos.Shopify.Product;
using Application.Interfaces.Shopify;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Shopify;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class ShopifyProductController(IShopifyProductService productService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(long id) =>
        Ok(await productService.GetProductByIdAsync(id));

    [HttpGet("all")]
    public async Task<IActionResult> GetProducts(
        [FromQuery] DateTime? updatedBefore,
        [FromQuery] DateTime? updatedAfter
    ) => Ok(await productService.GetProductsAsync(updatedBefore, updatedAfter));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(
        long id,
        [FromBody] ShopifyProductRequestDto product
    ) => Ok(await productService.UpdateProductAsync(product));
}
