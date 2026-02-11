using Application.Interfaces.Shopify;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopifyOrderController(IShopifyOrderService orderService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(
            long id,
            CancellationToken cancellationToken
        ) => Ok(await orderService.GetOrderByIdAsync(id, cancellationToken));
    }
}
