using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class DebugController : ControllerBase
{
    [HttpGet("auth-debug")]
    public IActionResult AuthDebug()
    {
        return Ok(
            new
            {
                IsAuthenticated = User.Identity?.IsAuthenticated,
                Claims = User.Claims.Select(c => new { c.Type, c.Value }),
            }
        );
    }
}
