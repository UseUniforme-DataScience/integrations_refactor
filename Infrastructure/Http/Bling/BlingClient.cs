using System.Net.Http.Headers;
using System.Text.Json;
using Application.Dtos.Bling.Invoice;
using Application.Dtos.Bling.Logistic;
using Application.Dtos.Bling.Order;
using Application.Interfaces.Bling;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Http.Bling;

public class BlingClient : IBlingClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public BlingClient(
        HttpClient httpClient,
        IConfiguration configuration,
        IBlingTokenClient tokenClient
    )
    {
        _httpClient = httpClient;

        var accessToken =
            tokenClient.GetOrRefreshAccessTokenAsync().GetAwaiter().GetResult()?.AccessToken
            ?? throw new InvalidOperationException("Failed to get access token");

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            accessToken
        );

        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        _baseUrl =
            configuration["Bling:BaseUrl"]
            ?? throw new InvalidOperationException("Bling base URL is not configured");
    }

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
    };

    public async Task<List<BlingOrderSearchDto>?> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/pedidos/vendas?numerosLojas[]={shopifyId}");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var responseDto = JsonSerializer.Deserialize<BlingOrderSearchResponseDto>(
            content,
            JsonOptions
        );
        return responseDto?.Data;
    }

    public async Task<BlingOrderDto?> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/pedidos/vendas/{orderId}");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var responseDto = JsonSerializer.Deserialize<BlingOrderResponseDto>(content, JsonOptions);
        return responseDto?.Data;
    }

    public async Task<BlingInvoiceDto?> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/nfe/{invoiceId}");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var responseDto = JsonSerializer.Deserialize<BlingInvoiceResponseDto>(content, JsonOptions);
        return responseDto?.Data;
    }

    public async Task<BlingLogisticDto?> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/logisticas/objetos/{logisticId}");
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        var responseDto = JsonSerializer.Deserialize<BlingLogisticResponseDto>(
            content,
            JsonOptions
        );
        return responseDto?.Data;
    }
}
