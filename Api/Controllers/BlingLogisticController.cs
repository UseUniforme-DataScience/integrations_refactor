using Application.Interfaces.Bling;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlingLogisticController(IBlingLogisticService logisticService) : ControllerBase
{
    [HttpGet("{logisticId}")]
    public async Task<IActionResult> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken
    ) => Ok(await logisticService.GetLogisticByIdAsync(logisticId, cancellationToken));
}
