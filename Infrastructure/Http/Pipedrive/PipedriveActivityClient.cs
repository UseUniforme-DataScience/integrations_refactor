using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Application.Dtos.Pipedrive.Activities;
using Application.Interfaces.Pipedrive;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Http.Pipedrive;

public class PipedriveActivityClient : IPipedriveActivityClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _apiKey;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
    };

    public PipedriveActivityClient(HttpClient httpClient, IConfiguration configuration)
    {
        _baseUrl =
            configuration["Pipedrive:BaseUrl"]
            ?? throw new InvalidOperationException("Pipedrive base URL is not configured");
        _apiKey =
            configuration["Pipedrive:ApiKey"]
            ?? throw new InvalidOperationException("Pipedrive API key is not configured");

        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("x-api-token", _apiKey);
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

    public async Task<bool> DoneActivityAsync(
        int activityId,
        CancellationToken cancellationToken = default
    )
    {
        var body = new { done = "true" };
        var url = new Uri($"{_baseUrl}/activities/{activityId}");
        var response = await _httpClient.PatchAsJsonAsync(url, body, cancellationToken);
        response.EnsureSuccessStatusCode();
        return true;
    }

    public async Task<bool> DoneAllActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var activities = await GetActivitiesFromDealAsync(dealId, cancellationToken);
        foreach (var activity in activities ?? [])
        {
            await DoneActivityAsync(activity.Id, cancellationToken);
        }
        return true;
    }

    public async Task<List<PipedriveActivityDto>?> GetActivitiesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/activities?deal_id={dealId}&limit=100");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var jsonData = JsonSerializer.Deserialize<PipedriveActivitiesResponseDto>(
            content,
            JsonOptions
        );
        return jsonData?.Data ?? [];
    }

    public async Task<List<PipedriveActivityDto>?> GetActivitiesFromPersonAsync(
        int personId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/activities?person_id={personId}&limit=100");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var jsonData = JsonSerializer.Deserialize<PipedriveActivitiesResponseDto>(
            content,
            JsonOptions
        );
        return jsonData?.Data ?? [];
    }
}
