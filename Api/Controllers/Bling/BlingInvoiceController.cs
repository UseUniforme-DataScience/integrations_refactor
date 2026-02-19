using Application.Interfaces.Bling;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Bling;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class BlingInvoiceController(IBlingInvoiceService invoiceService) : ControllerBase
{
    [HttpGet("{invoiceId}")]
    public async Task<IActionResult> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken
    ) => Ok(await invoiceService.GetInvoiceByIdAsync(invoiceId, cancellationToken));
}
