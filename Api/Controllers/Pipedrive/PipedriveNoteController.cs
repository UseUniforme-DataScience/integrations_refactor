using Application.Dtos.Pipedrive.Note;
using Application.Interfaces.Pipedrive;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pipedrive;

[ApiController]
[Route("api/pipedrive/notes")]
[Authorize(Roles = Roles.admin)]
public class PipedriveNoteController(IPipedriveNoteService noteService) : ControllerBase
{
    [HttpGet("deal/{dealId}")]
    public async Task<IActionResult> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    ) => Ok(await noteService.GetNotesFromDealAsync(dealId, cancellationToken));

    [HttpPost]
    public async Task<IActionResult> CreateNoteAsync(
        [FromBody] PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    )
    {
        try
        {
            var result = await noteService.CreateNoteAsync(note, cancellationToken);
            return result is null ? BadRequest() : Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
