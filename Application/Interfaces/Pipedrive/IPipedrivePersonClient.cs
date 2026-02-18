using Application.Dtos.Pipedrive.Person;

namespace Application.Interfaces.Pipedrive;

public interface IPipedrivePersonClient
{
    Task<PipedrivePersonResponseDto?> CreatePersonAsync(
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    );

    Task<PipedrivePersonResponseDto?> UpdatePersonAsync(
        int personId,
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    );

    Task<PipedrivePersonResponseDto?> MergePersonsAsync(
        int primaryPersonId,
        int secondaryPersonId,
        CancellationToken cancellationToken = default
    );

    Task<bool> DeletePersonAsync(int personId, CancellationToken cancellationToken = default);

    Task<PipedrivePersonResponseDto?> GetPersonByIdAsync(
        int personId,
        CancellationToken cancellationToken = default
    );

    Task<PipedrivePersonsResponseDto?> GetPersonsByEmailAsync(
        string email,
        bool exactMatch = true,
        CancellationToken cancellationToken = default
    );

    Task<PipedrivePersonsResponseDto?> GetPersonsByPhoneAsync(
        string phone,
        CancellationToken cancellationToken = default
    );

    Task<PipedrivePersonsResponseDto?> GetPersonsByDocumentAsync(
        string document,
        CancellationToken cancellationToken = default
    );

    Task<PipedrivePersonResponseDto?> GetPersonWithTwoMatchesAsync(
        string email,
        string phone,
        string document,
        CancellationToken cancellationToken = default
    );
}
