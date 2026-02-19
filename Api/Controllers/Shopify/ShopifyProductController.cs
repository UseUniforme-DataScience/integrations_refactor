using Application.Dtos.Shopify;
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

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(long id, [FromBody] ShopifyProductDto product) =>
        Ok(await productService.UpdateProductAsync(product));
}
