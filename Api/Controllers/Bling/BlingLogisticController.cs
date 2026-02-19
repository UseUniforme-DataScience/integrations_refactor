using Application.Interfaces.Bling;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Bling;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class BlingLogisticController(IBlingLogisticService logisticService) : ControllerBase
{
    [HttpGet("{logisticId}")]
    public async Task<IActionResult> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken
    ) => Ok(await logisticService.GetLogisticByIdAsync(logisticId, cancellationToken));
}
