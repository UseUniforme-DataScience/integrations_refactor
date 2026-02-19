using Application.Interfaces.Bling;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Bling;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class BlingTokenController(IBlingTokenService blingTokenService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetToken(CancellationToken cancellationToken) =>
        Ok(await blingTokenService.GetTokenAsync(cancellationToken));
}
