using Application.Dtos.Shopify.Order;
using Application.Interfaces.Shopify;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Shopify;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class ShopifyOrderController(IShopifyOrderService orderService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderById(long id, CancellationToken cancellationToken) =>
        Ok(await orderService.GetOrderByIdAsync(id, cancellationToken));

    [HttpGet("all")]
    public async Task<IActionResult> GetOrders(
        [FromQuery] DateTime? updatedBefore,
        [FromQuery] DateTime? updatedAfter
    ) => Ok(await orderService.GetOrdersAsync(updatedBefore, updatedAfter));

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrder(
        [FromBody] ShopifyOrderRequestDto order,
        CancellationToken cancellationToken
    ) => Ok(await orderService.UpdateOrderAsync(order, cancellationToken));
}
