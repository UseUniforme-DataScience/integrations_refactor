using Application.Interfaces.Pipedrive;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pipedrive;

[ApiController]
[Route("api/pipedrive/activities")]
public class PipedriveActivityController(IPipedriveActivityService activityService) : ControllerBase
{
    [HttpGet("deal/{dealId}")]
    public async Task<IActionResult> GetActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) => Ok(await activityService.GetActivitiesFromDealAsync(dealId, cancellationToken));

    [HttpGet("person/{personId}")]
    public async Task<IActionResult> GetActivitiesFromPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) => Ok(await activityService.GetActivitiesFromPersonAsync(personId, cancellationToken));

    [HttpPost("{activityId}/done")]
    public async Task<IActionResult> DoneActivityAsync(
        int activityId,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            await activityService.DoneActivityAsync(activityId, cancellationToken);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("deal/{dealId}/done-all")]
    public async Task<IActionResult> DoneAllActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            await activityService.DoneAllActivitiesFromDealAsync(dealId, cancellationToken);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
