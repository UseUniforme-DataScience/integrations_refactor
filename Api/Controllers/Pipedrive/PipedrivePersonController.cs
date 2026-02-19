using Application.Dtos.Pipedrive.Person;
using Application.Interfaces.Pipedrive;
using Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Pipedrive;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = Roles.admin)]
public class PipedrivePersonController(IPipedrivePersonService personService) : ControllerBase
{
    [HttpGet("{personId}")]
    public async Task<IActionResult> GetPersonByIdAsync(
        [FromRoute] int personId,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.GetPersonByIdAsync(personId, cancellationToken));

    [HttpGet("email/{email}")]
    public async Task<IActionResult> GetPersonsByEmailAsync(
        [FromRoute] string email,
        [FromQuery] bool exactMatch = true,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.GetPersonsByEmailAsync(email, exactMatch, cancellationToken));

    [HttpGet("phone/{phone}")]
    public async Task<IActionResult> GetPersonsByPhoneAsync(
        [FromRoute] string phone,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.GetPersonsByPhoneAsync(phone, cancellationToken));

    [HttpGet("document/{document}")]
    public async Task<IActionResult> GetPersonsByDocumentAsync(
        [FromRoute] string document,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.GetPersonsByDocumentAsync(document, cancellationToken));

    [HttpGet("two-matches")]
    public async Task<IActionResult> GetPersonWithTwoMatchesAsync(
        [FromQuery] string email,
        [FromQuery] string phone,
        [FromQuery] string document,
        CancellationToken cancellationToken = default
    ) =>
        Ok(
            await personService.GetPersonWithTwoMatchesAsync(
                email,
                phone,
                document,
                cancellationToken
            )
        );

    [HttpPost]
    public async Task<IActionResult> CreatePersonAsync(
        [FromBody] PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.CreatePersonAsync(person, cancellationToken));

    [HttpPut("{personId}")]
    public async Task<IActionResult> UpdatePersonAsync(
        [FromRoute] int personId,
        [FromBody] PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.UpdatePersonAsync(personId, person, cancellationToken));

    [HttpDelete("{personId}")]
    public async Task<IActionResult> DeletePersonAsync(
        [FromRoute] int personId,
        CancellationToken cancellationToken = default
    ) => Ok(await personService.DeletePersonAsync(personId, cancellationToken));

    [HttpPost("merge")]
    public async Task<IActionResult> MergePersonsAsync(
        [FromQuery] int primaryPersonId,
        [FromQuery] int secondaryPersonId,
        CancellationToken cancellationToken = default
    ) =>
        Ok(
            await personService.MergePersonsAsync(
                primaryPersonId,
                secondaryPersonId,
                cancellationToken
            )
        );
}
