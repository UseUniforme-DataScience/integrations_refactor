using Application.Dtos.Shopify;
using Application.Interfaces.Shopify;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Shopify;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class ShopifyCustomerController(IShopifyCustomerService customerService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomerById(long id) =>
        Ok(await customerService.GetCustomerByIdAsync(id));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(
        long id,
        [FromBody] ShopifyCustomerDto customer
    ) => Ok(await customerService.UpdateCustomerAsync(id, customer));
}
