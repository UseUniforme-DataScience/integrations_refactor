using Application.Dtos.Pipedrive.Deal;
using Application.Interfaces.Pipedrive;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pipedrive;

[ApiController]
[Route("api/pipedrive/deals")]
public class PipedriveDealController(IPipedriveDealService dealService) : ControllerBase
{
    [HttpGet("{dealId}")]
    public async Task<IActionResult> GetDealByIdAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var result = await dealService.GetDealByIdAsync(dealId, cancellationToken);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpGet("person/{personId}")]
    public async Task<IActionResult> GetDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) => Ok(await dealService.GetDealsByPersonAsync(personId, cancellationToken));

    [HttpGet("person/{personId}/archived")]
    public async Task<IActionResult> GetDealsByPersonWithArchivedAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) => Ok(await dealService.GetDealsByPersonWithArchivedAsync(personId, cancellationToken));

    [HttpGet("person/{personId}/open")]
    public async Task<IActionResult> GetOpenDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) => Ok(await dealService.GetOpenDealsByPersonAsync(personId, cancellationToken));

    [HttpPost]
    public async Task<IActionResult> CreateDealAsync(
        [FromBody] PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await dealService.CreateDealAsync(deal, cancellationToken);
            return result is null ? BadRequest() : Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{dealId}")]
    public async Task<IActionResult> UpdateDealAsync(
        int dealId,
        [FromBody] PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await dealService.UpdateDealAsync(dealId, deal, cancellationToken);
            return result is null ? NotFound() : Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{dealId}")]
    public async Task<IActionResult> DeleteDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            await dealService.DeleteDealAsync(dealId, cancellationToken);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("{dealId}/duplicate")]
    public async Task<IActionResult> DuplicateDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var result = await dealService.DuplicateDealAsync(dealId, cancellationToken);
        return result is null ? BadRequest() : Ok(result);
    }

    [HttpPost("{dealId}/duplicate-and-update")]
    public async Task<IActionResult> DuplicateAndUpdateDealAsync(
        int dealId,
        [FromBody] PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await dealService.DuplicateAndUpdateDealAsync(
                dealId,
                deal,
                cancellationToken
            );
            return result is null ? BadRequest() : Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("merge")]
    public async Task<IActionResult> MergeDealsAsync(
        [FromQuery] int primaryDealId,
        [FromQuery] int secondaryDealId,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await dealService.MergeDealsAsync(
                primaryDealId,
                secondaryDealId,
                cancellationToken
            );
            return result is null ? BadRequest() : Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
