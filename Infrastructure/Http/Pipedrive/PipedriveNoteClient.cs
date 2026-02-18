using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Application.Dtos.Pipedrive.Note;
using Application.Interfaces.Pipedrive;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Http.Pipedrive;

public class PipedriveNoteClient : IPipedriveNoteClient
{
    private readonly HttpClient _httpClient;
    private readonly string _oldBaseUrl;
    private readonly string _apiKey;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    };

    public PipedriveNoteClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
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

    public async Task<PipedriveNotesResponseDto?> GetNotesFromDealAsync(
        int dealId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_oldBaseUrl}/notes?deal_id={dealId}&limit=100");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveNotesResponseDto>(content, JsonOptions);
    }

    public async Task<PipedriveNoteCreateResponseDto?> CreateNoteAsync(
        PipedriveNoteRequestDto note,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_oldBaseUrl}/notes");
        var response = await _httpClient.PostAsJsonAsync(url, note, JsonOptions, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<PipedriveNoteCreateResponseDto>(content, JsonOptions);
    }
}
