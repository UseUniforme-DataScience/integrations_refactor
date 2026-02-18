using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Application.Dtos.Pipedrive.Deal;
using Application.Interfaces.Pipedrive;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Http.Pipedrive;

public class PipedriveDealClient : IPipedriveDealClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    private readonly string _oldBaseUrl;
    private readonly string _apiKey;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
    };

    public PipedriveDealClient(HttpClient httpClient, IConfiguration configuration)
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

    public async Task<PipedriveDealResponseDto?> CreateDealAsync(
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/deals");
        var response = await _httpClient.PostAsJsonAsync(url, deal, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealResponseDto>(content, JsonOptions);
    }

    // public async Task<PipedriveDealResponseDto?> CreateOrUpdateDealAndDeleteOthersAsync(
    //     PipedriveDealRequestDto deal,
    //     CancellationToken cancellationToken = default
    // )
    // {
    //     if (deal.PersonId is null)
    //     {
    //         throw new InvalidOperationException("Person ID is required");
    //     }
    //     var openDeals = await GetOpenDealsByPersonAsync(deal.PersonId, cancellationToken);
    //     var totalOpenDeals = openDeals?.Data?.Count ?? 0;

    //     if (totalOpenDeals == 0) { }
    //     if (totalOpenDeals == 1) { }
    //     if (totalOpenDeals > 1) { }
    // }

    public async Task<bool> DeleteDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/deals/{dealId}");
        var response = await _httpClient.DeleteAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        return true;
    }

    public async Task<PipedriveDealResponseDto?> DuplicateAndUpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    )
    {
        var duplicatedDeal = await DuplicateDealAsync(dealId, cancellationToken);
        if (duplicatedDeal is null)
        {
            return null;
        }
        return await UpdateDealAsync(duplicatedDeal.Id, deal, cancellationToken);
    }

    public async Task<PipedriveDealResponseDto?> DuplicateDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/deals/{dealId}/duplicate");
        var response = await _httpClient.PostAsJsonAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveGetDealResponseDto?> GetDealByIdAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/deals/{dealId}");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveGetDealResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveDealsListResponseDto?> GetDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri(
            $"{_oldBaseUrl}/deals/list?connected_to=person&connected_to_id={personId}&archived_status=all&limit=100"
        );
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealsListResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveDealsListResponseDto?> GetDealsByPersonWithArchivedAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri(
            $"{_oldBaseUrl}/deals/list?person_id={personId}&archived_status=all&limit=100"
        );
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealsListResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveDealsResponseDto?> GetOpenDealsByPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri(
            $"{_baseUrl}/deals?person_id={personId}&status=open&sort_by=update_time&sort_direction=desc&limit=100"
        );
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealsResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveDealResponseDto?> UpdateDealAsync(
        int dealId,
        PipedriveDealRequestDto deal,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/deals/{dealId}");
        var response = await _httpClient.PutAsJsonAsync(url, deal, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveDealResponseDto?> MergeDealsAsync(
        int primaryDealId,
        int secondaryDealId,
        CancellationToken cancellationToken = default
    )
    {
        var body = new { merge_with_id = primaryDealId };
        var url = new Uri($"{_oldBaseUrl}/deals/{secondaryDealId}/merge");
        var response = await _httpClient.PostAsJsonAsync(url, body, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveDealResponseDto>(content, JsonOptions);
    }
}
