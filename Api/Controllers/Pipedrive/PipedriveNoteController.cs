using Application.Dtos.Pipedrive;
using Application.Interfaces.Pipedrive;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pipedrive;

[ApiController]
[Route("api/pipedrive/notes")]
public class PipedriveNoteController(IPipedriveNoteClient noteClient) : ControllerBase
{
    [HttpGet("deal/{dealId}")]
    public async Task<IActionResult> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) => Ok(await noteClient.GetNotesFromDealAsync(dealId, cancellationToken));

    [HttpPost]
    public async Task<IActionResult> CreateNoteAsync(
        [FromBody] PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await noteClient.CreateNoteAsync(note, cancellationToken);
            return result is null ? BadRequest() : Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
