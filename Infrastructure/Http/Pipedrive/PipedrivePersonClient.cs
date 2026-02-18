using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Application.Dtos.Pipedrive.Person;
using Application.Interfaces.Pipedrive;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Http.Pipedrive;

public class PipedrivePersonClient : IPipedrivePersonClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _oldBaseUrl;
    private readonly string _apiKey;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    };

    public PipedrivePersonClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _baseUrl =
            configuration["Pipedrive:BaseUrl"]
            ?? throw new InvalidOperationException("Pipedrive base URL is not configured");
        _oldBaseUrl =
            configuration["Pipedrive:OldBaseUrl"]
            ?? throw new InvalidOperationException("Pipedrive old base URL is not configured");
        _apiKey =
            configuration["Pipedrive:ApiKey"]
            ?? throw new InvalidOperationException("Pipedrive API key is not configured");

        _httpClient.DefaultRequestHeaders.Add("x-api-token", _apiKey);
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

    public async Task<PipedrivePersonResponseDto?> CreatePersonAsync(
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/persons");
        var response = await _httpClient.PostAsJsonAsync(
            url,
            person,
            JsonOptions,
            cancellationToken
        );
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonResponseDto>(content, JsonOptions);
    }

    public async Task<bool> DeletePersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/persons/{personId}");
        var response = await _httpClient.DeleteAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        return true;
    }

    public async Task<PipedrivePersonResponseDto?> MergePersonsAsync(
        int primaryPersonId,
        int secondaryPersonId,
        CancellationToken cancellationToken = default
    )
    {
        var body = new { merge_with_id = primaryPersonId };
        var url = new Uri($"{_oldBaseUrl}/persons/{secondaryPersonId}/merge");
        var response = await _httpClient.PutAsJsonAsync(url, body, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonResponseDto>(content, JsonOptions);
    }

    public async Task<PipedrivePersonResponseDto?> UpdatePersonAsync(
        int personId,
        PipedrivePersonRequestDto person,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/persons/{personId}");
        var response = await _httpClient.PatchAsJsonAsync(
            url,
            person,
            JsonOptions,
            cancellationToken
        );
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonResponseDto>(content, JsonOptions);
    }

    public async Task<PipedrivePersonResponseDto?> GetPersonByIdAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/persons/{personId}");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonResponseDto>(content, JsonOptions);
    }

    public async Task<PipedrivePersonsResponseDto?> GetPersonsByDocumentAsync(
        string document,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri(
            $"{_oldBaseUrl}/persons/search?term={document}&fields=document&exact_match=true"
        );
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonsResponseDto>(content, JsonOptions);
    }

    public async Task<PipedrivePersonsResponseDto?> GetPersonsByEmailAsync(
        string email,
        bool exactMatch = true,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri(
            $"{_oldBaseUrl}/persons/search?term={email}&fields=email&exact_match={exactMatch}"
        );
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonsResponseDto>(content, JsonOptions);
    }

    public async Task<PipedrivePersonsResponseDto?> GetPersonsByPhoneAsync(
        string phone,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri(
            $"{_oldBaseUrl}/persons/search?term={phone}&fields=phone&exact_match=true"
        );
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedrivePersonsResponseDto>(content, JsonOptions);
    }

    public async Task<PipedrivePersonResponseDto?> GetPersonWithTwoMatchesAsync(
        string email,
        string phone,
        string document,
        CancellationToken cancellationToken = default
    )
    {
        var emailMatches = await GetPersonsByEmailAsync(email, true, cancellationToken);
        var phoneMatches = await GetPersonsByPhoneAsync(phone, cancellationToken);
        var documentMatches = await GetPersonsByDocumentAsync(document, cancellationToken);

        List<int> personIds = [];

        foreach (var match in emailMatches?.Data ?? [])
        {
            personIds.Add(match.Id);
        }
        foreach (var match in phoneMatches?.Data ?? [])
        {
            personIds.Add(match.Id);
        }
        foreach (var match in documentMatches?.Data ?? [])
        {
            personIds.Add(match.Id);
        }

        var mostFrequentPersonId = personIds
            .GroupBy(id => id)
            .OrderByDescending(group => group.Count())
            .First()
            .Key;

        return await GetPersonByIdAsync(mostFrequentPersonId, cancellationToken);
    }
}
