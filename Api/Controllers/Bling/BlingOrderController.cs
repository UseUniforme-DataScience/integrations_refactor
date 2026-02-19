using Application.Interfaces.Bling;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Bling;

[ApiController]
[Authorize(Roles = Roles.admin)]
[Route("api/[controller]")]
public class BlingOrderController(IBlingOrderService orderService) : ControllerBase
{
    [HttpGet("search/{shopifyId}")]
    public async Task<IActionResult> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken
    ) => Ok(await orderService.SearchOrderbyShopiyIdAsync(shopifyId, cancellationToken));

    [HttpGet("{orderId}")]
    public async Task<IActionResult> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken
    ) => Ok(await orderService.GetOrderByIdAsync(orderId, cancellationToken));
}
