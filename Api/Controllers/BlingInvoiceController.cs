using Application.Interfaces.Bling;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlingInvoiceController(IBlingInvoiceService invoiceService) : ControllerBase
{
    [HttpGet("{invoiceId}")]
    public async Task<IActionResult> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken
    ) => Ok(await invoiceService.GetInvoiceByIdAsync(invoiceId, cancellationToken));
}
