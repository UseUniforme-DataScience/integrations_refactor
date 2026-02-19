using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Application.Dtos.Shopify.Customer;
using Application.Dtos.Shopify.Order;
using Application.Dtos.Shopify.Product;
using Application.Interfaces.Shopify;
using Microsoft.Extensions.Options;

namespace Infrastructure.Http.Shopify;

public class ShopifyClient : IShopifyClient
{
    private readonly HttpClient _httpClient;
    private readonly ShopifyOptions _options;
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
    };

    public ShopifyClient(HttpClient httpClient, IOptions<ShopifyOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
        _httpClient.BaseAddress = new Uri(_options.BaseUrl + "/");
        _httpClient.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _options.ApiKey);
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

    public async Task<ShopifyOrderDto?> GetOrderAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _httpClient
            .GetAsync($"orders/{id}.json", cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyOrderResponseDto>(content, JsonOptions);
        return wrapper?.Order;
    }

    public async Task<List<ShopifyOrderDto>?> GetOrdersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var updatedBreforeString = updatedBefore is not null
            ? updatedBefore.Value.ToUniversalTime()
            : DateTime.Now.AddDays(-7).ToUniversalTime();
        var updatedAfterString = updatedAfter is not null
            ? updatedAfter.Value.ToUniversalTime()
            : DateTime.Now.ToUniversalTime();
        var response = await _httpClient
            .GetAsync(
                $"orders.json?updated_at_min={updatedBreforeString}&updated_at_max={updatedAfterString}",
                cancellationToken
            )
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyOrdersResponseDto>(content, JsonOptions);
        return wrapper?.Orders;
    }

    public async Task<ShopifyOrderDto?> PutOrderAsync(
        long id,
        ShopifyOrderRequestDto order,
        CancellationToken cancellationToken = default
    )
    {
        var body = JsonSerializer.Serialize(new { order }, JsonOptions);
        var response = await _httpClient
            .PutAsync(
                $"orders/{id}.json",
                new StringContent(body, Encoding.UTF8, "application/json"),
                cancellationToken
            )
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyOrderResponseDto>(content, JsonOptions);
        return wrapper?.Order;
    }

    public async Task<ShopifyProductDto?> GetProductAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _httpClient
            .GetAsync($"products/{id}.json", cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyProductResponseDto>(content, JsonOptions);
        return wrapper?.Product;
    }

    public async Task<List<ShopifyProductDto>?> GetProductsAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var updatedBreforeString = updatedBefore is not null
            ? updatedBefore.Value.ToUniversalTime()
            : DateTime.Now.AddDays(-7).ToUniversalTime();
        var updatedAfterString = updatedAfter is not null
            ? updatedAfter.Value.ToUniversalTime()
            : DateTime.Now.ToUniversalTime();
        var response = await _httpClient
            .GetAsync(
                $"products.json?updated_at_min={updatedBreforeString}&updated_at_max={updatedAfterString}",
                cancellationToken
            )
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyProductsResponseDto>(content, JsonOptions);
        return wrapper?.Products;
    }

    public async Task<ShopifyProductDto?> PutProductAsync(
        long id,
        ShopifyProductRequestDto product,
        CancellationToken cancellationToken = default
    )
    {
        var body = JsonSerializer.Serialize(new { product }, JsonOptions);
        var response = await _httpClient
            .PutAsync(
                $"products/{id}.json",
                new StringContent(body, Encoding.UTF8, "application/json"),
                cancellationToken
            )
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyProductResponseDto>(content, JsonOptions);
        return wrapper?.Product;
    }

    public async Task<ShopifyCustomerDto?> GetCustomerAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _httpClient
            .GetAsync($"customers/{id}.json", cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyCustomerResponseDto>(content, JsonOptions);
        return wrapper?.Customer;
    }

    public async Task<List<ShopifyCustomerDto>?> GetCustomersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var updatedBreforeString = updatedBefore is not null
            ? updatedBefore.Value.ToUniversalTime()
            : DateTime.Now.AddDays(-7).ToUniversalTime();
        var updatedAfterString = updatedAfter is not null
            ? updatedAfter.Value.ToUniversalTime()
            : DateTime.Now.ToUniversalTime();
        var response = await _httpClient
            .GetAsync(
                $"customers.json?updated_at_min={updatedBreforeString}&updated_at_max={updatedAfterString}",
                cancellationToken
            )
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyCustomersResponseDto>(content, JsonOptions);
        return wrapper?.Customers;
    }

    public async Task<ShopifyCustomerDto?> PutCustomerAsync(
        long id,
        ShopifyCustomerRequestDto customer,
        CancellationToken cancellationToken = default
    )
    {
        var body = JsonSerializer.Serialize(new { customer }, JsonOptions);
        var response = await _httpClient
            .PutAsync(
                $"customers/{id}.json",
                new StringContent(body, Encoding.UTF8, "application/json"),
                cancellationToken
            )
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        var content = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);
        var wrapper = JsonSerializer.Deserialize<ShopifyCustomerResponseDto>(content, JsonOptions);
        return wrapper?.Customer;
    }
}
