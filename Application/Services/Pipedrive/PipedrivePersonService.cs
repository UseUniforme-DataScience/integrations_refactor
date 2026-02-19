using Application.Dtos.Pipedrive.Person;
using Application.Interfaces.Pipedrive;

namespace Application.Services.Pipedrive;

public class PipedrivePersonService(IPipedrivePersonClient personClient) : IPipedrivePersonService
{
    public async Task<PipedrivePersonDataDto?> CreatePersonAsync(
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    ) => await personClient.CreatePersonAsync(person, cancellationToken).ConfigureAwait(false);

    public async Task<PipedrivePersonDataDto?> UpdatePersonAsync(
        int personId,
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    ) =>
        await personClient
            .UpdatePersonAsync(personId, person, cancellationToken)
            .ConfigureAwait(false);

    public async Task<PipedrivePersonDataDto?> MergePersonsAsync(
        int primaryPersonId,
        int secondaryPersonId,
        CancellationToken cancellationToken = default
    ) =>
        await personClient
            .MergePersonsAsync(primaryPersonId, secondaryPersonId, cancellationToken)
            .ConfigureAwait(false);

    public async Task<bool> DeletePersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    ) => await personClient.DeletePersonAsync(personId, cancellationToken).ConfigureAwait(false);

    public async Task<PipedrivePersonDataDto?> GetPersonByIdAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var response = await personClient
            .GetPersonByIdAsync(personId, cancellationToken)
            .ConfigureAwait(false);
        return response;
    }

    public async Task<List<PipedrivePersonDataDto>?> GetPersonsByEmailAsync(
        string email,
        bool exactMatch = true,
        CancellationToken cancellationToken = default
    )
    {
        var persons = await personClient
            .GetPersonsByEmailAsync(email, exactMatch, cancellationToken)
            .ConfigureAwait(false);
        return persons ?? [];
    }

    public async Task<List<PipedrivePersonDataDto>?> GetPersonsByPhoneAsync(
        string phone,
        CancellationToken cancellationToken = default
    )
    {
        var persons = await personClient
            .GetPersonsByPhoneAsync(phone, cancellationToken)
            .ConfigureAwait(false);
        return persons ?? [];
    }

    public async Task<List<PipedrivePersonDataDto>?> GetPersonsByDocumentAsync(
        string document,
        CancellationToken cancellationToken = default
    )
    {
        var persons = await personClient
            .GetPersonsByDocumentAsync(document, cancellationToken)
            .ConfigureAwait(false);
        return persons ?? [];
    }

    public async Task<PipedrivePersonDataDto?> GetPersonWithTwoMatchesAsync(
        string email,
        string phone,
        string document,
        CancellationToken cancellationToken = default
    ) =>
        await personClient
            .GetPersonWithTwoMatchesAsync(email, phone, document, cancellationToken)
            .ConfigureAwait(false);
}
