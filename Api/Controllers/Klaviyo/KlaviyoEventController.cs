using Application.Dtos.Klaviyo;
using Application.Interfaces.Klaviyo;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Klaviyo;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class KlaviyoEventController(IKlaviyoEventService klaviyoEventService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendEventAsync(
        [FromBody] KlaviyoEventRequestDto eventDto,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            await klaviyoEventService.SendEventAsync(eventDto, cancellationToken);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>Envia múltiplos eventos ao Klaviyo em lotes.</summary>
    /// <param name="events">Lista de eventos a enviar.</param>
    /// <param name="batchSize">Tamanho do lote (100–1000). Padrão: 500.</param>
    /// <param name="requestsIntervalSeconds">Segundos de espera entre lotes. Padrão: 10.</param>
    [HttpPost("bulk")]
    public async Task<IActionResult> SendEventsInBulkAsync(
        [FromBody] List<KlaviyoEventRequestDto> events,
        [FromQuery] int batchSize = 500,
        [FromQuery] int requestsIntervalSeconds = 10,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            await klaviyoEventService.SendEventsInBulkAsync(
                events,
                batchSize,
                requestsIntervalSeconds,
                cancellationToken
            );
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
