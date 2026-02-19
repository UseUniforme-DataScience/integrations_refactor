using Application.Dtos.Pipedrive.Person;

namespace Application.Interfaces.Pipedrive;

public interface IPipedrivePersonService
{
    Task<PipedrivePersonDataDto?> CreatePersonAsync(
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    );
    Task<PipedrivePersonDataDto?> UpdatePersonAsync(
        int personId,
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    );
    Task<PipedrivePersonDataDto?> MergePersonsAsync(
        int primaryPersonId,
        int secondaryPersonId,
        CancellationToken cancellationToken = default
    );
    Task<bool> DeletePersonAsync(int personId, CancellationToken cancellationToken = default);
    Task<PipedrivePersonDataDto?> GetPersonByIdAsync(
        int personId,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedrivePersonDataDto>?> GetPersonsByEmailAsync(
        string email,
        bool exactMatch = true,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedrivePersonDataDto>?> GetPersonsByPhoneAsync(
        string phone,
        CancellationToken cancellationToken = default
    );
    Task<List<PipedrivePersonDataDto>?> GetPersonsByDocumentAsync(
        string document,
        CancellationToken cancellationToken = default
    );
    Task<PipedrivePersonDataDto?> GetPersonWithTwoMatchesAsync(
        string email,
        string phone,
        string document,
        CancellationToken cancellationToken = default
    );
}
