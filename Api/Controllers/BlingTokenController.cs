using Application.Interfaces.Bling;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlingTokenController(IBlingTokenService blingTokenService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetToken(CancellationToken cancellationToken) =>
            Ok(await blingTokenService.GetTokenAsync(cancellationToken));
    }
}
