using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Bling;
using Application.Dtos.Bling.Token;
using Application.Interfaces.Bling;
using Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Http.Bling;

public class BlingTokenClient : IBlingTokenClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IRedisService _redisService;
    private string _codeUrl = string.Empty;
    private string _tokenBaseUrl = string.Empty;
    private string _clientId = string.Empty;
    private string _clientSecret = string.Empty;
    private string _clientIdAndSecretBase64 = string.Empty;
    private string _accessToken = string.Empty;
    private int _expiresIn = 0;
    private string _tokenType = string.Empty;
    private string _refreshToken = string.Empty;
    private string _scope = string.Empty;
    private DateTime _obtainedAt = DateTime.MinValue;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
    };

    public BlingTokenClient(
        IHttpClientFactory httpClientFactory,
        IConfiguration configuration,
        IRedisService redisService
    )
    {
        _httpClientFactory = httpClientFactory;
        _redisService = redisService;
        LoadCachedAccessTokenAsync().GetAwaiter().GetResult();
        LoadEnvironmentVariables(configuration);
        GetOrRefreshAccessTokenAsync().GetAwaiter().GetResult();
    }

    private HttpClient GetHttpClient() =>
        _httpClientFactory.CreateClient(BlingServiceCollection.BlingTokenHttpClientName);

    private async void SetTokenData(BlingAccessTokenResponseDto? tokenData)
    {
        _accessToken = tokenData?.AccessToken ?? null!;
        _expiresIn = tokenData?.ExpiresIn ?? 0;
        _tokenType = tokenData?.TokenType ?? null!;
        _refreshToken = tokenData?.RefreshToken ?? null!;
        _scope = tokenData?.Scope ?? null!;
        _obtainedAt = tokenData?.ObtainedAt ?? DateTime.UtcNow;

        await SaveTokenToCacheAsync(tokenData);
    }

    private void LoadEnvironmentVariables(IConfiguration configuration)
    {
        _codeUrl =
            configuration["Bling:CodeUrl"]
            ?? throw new InvalidOperationException("Bling code URL is not configured");
        _tokenBaseUrl =
            configuration["Bling:TokenBaseUrl"]
            ?? throw new InvalidOperationException("Bling token base URL is not configured");

        _clientId =
            configuration["Bling:ClientId"]
            ?? throw new InvalidOperationException("Bling client ID is not configured");
        _clientSecret =
            configuration["Bling:ClientSecret"]
            ?? throw new InvalidOperationException("Bling client secret is not configured");

        var clientIdAndSecret = $"{_clientId}:{_clientSecret}";

        _clientIdAndSecretBase64 = Convert.ToBase64String(
            Encoding.UTF8.GetBytes(clientIdAndSecret)
        );
    }

    private async Task<string> GetCodeAsync(CancellationToken cancellationToken = default)
    {
        var response = await GetHttpClient()
            .GetAsync(_codeUrl, cancellationToken)
            .ConfigureAwait(false);

        var content =
            response
                .Content.ReadFromJsonAsync<BlingCodeResponseDto>(JsonOptions, cancellationToken)
                .GetAwaiter()
                .GetResult()
            ?? throw new InvalidOperationException("Failed to get code");

        return content.AccessCode;
    }

    private async Task<BlingAccessTokenResponseDto?> GetAccessTokenAsync(
        CancellationToken cancellationToken = default
    )
    {
        var code = await GetCodeAsync(cancellationToken).ConfigureAwait(false);

        using var body = new FormUrlEncodedContent(
            new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "code", code },
            }
        );

        using var request = new HttpRequestMessage(HttpMethod.Post, _tokenBaseUrl);
        request.Content = body;
        request.Headers.TryAddWithoutValidation(
            "Authorization",
            $"Basic {_clientIdAndSecretBase64}"
        );

        var response = await GetHttpClient()
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            var error = await response
                .Content.ReadFromJsonAsync<BlingAccessTokenErrorResponseDto>(
                    JsonOptions,
                    cancellationToken
                )
                .ConfigureAwait(false);

            if (error?.Error?.Description == "The authorization code has expired")
            {
                code = await GetCodeAsync(cancellationToken).ConfigureAwait(false);

                using var retryBody = new FormUrlEncodedContent(
                    new Dictionary<string, string>
                    {
                        { "grant_type", "authorization_code" },
                        { "code", code },
                    }
                );

                using var retryRequest = new HttpRequestMessage(HttpMethod.Post, _tokenBaseUrl);
                retryRequest.Content = retryBody;
                retryRequest.Headers.TryAddWithoutValidation(
                    "Authorization",
                    $"Basic {_clientIdAndSecretBase64}"
                );

                response =
                    await GetHttpClient()
                        .SendAsync(retryRequest, cancellationToken)
                        .ConfigureAwait(false)
                    ?? throw new InvalidOperationException("Failed to get access token");
            }
        }

        var content = await response
            .Content.ReadFromJsonAsync<BlingAccessTokenResponseDto>(JsonOptions, cancellationToken)
            .ConfigureAwait(false);

        return content;
    }

    private async Task<BlingAccessTokenResponseDto?> RefreshAccessTokenAsync(
        CancellationToken cancellationToken = default
    )
    {
        using var body = new FormUrlEncodedContent(
            new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", _refreshToken },
            }
        );

        using var request = new HttpRequestMessage(HttpMethod.Post, _tokenBaseUrl);
        request.Content = body;
        request.Headers.TryAddWithoutValidation(
            "Authorization",
            $"Basic {_clientIdAndSecretBase64}"
        );
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await GetHttpClient()
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .Content.ReadFromJsonAsync<BlingAccessTokenResponseDto>(
                    JsonOptions,
                    cancellationToken
                )
                .ConfigureAwait(false)
            ?? throw new InvalidOperationException("Failed to refresh access token");
    }

    public async Task<BlingAccessTokenResponseDto?> GetOrRefreshAccessTokenAsync(
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrEmpty(_accessToken) || string.IsNullOrEmpty(_refreshToken))
        {
            var tokenData = await GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);

            SetTokenData(tokenData);

            return tokenData;
        }
        var tokenExpiresAt = _obtainedAt.AddSeconds(_expiresIn);
        if (DateTime.UtcNow >= tokenExpiresAt)
        {
            var accessToken =
                await RefreshAccessTokenAsync(cancellationToken).ConfigureAwait(false)
                ?? throw new InvalidOperationException("Failed to refresh access token");

            SetTokenData(accessToken);

            return accessToken;
        }

        return new BlingAccessTokenResponseDto
        {
            AccessToken = _accessToken,
            ExpiresIn = _expiresIn,
            TokenType = _tokenType,
            RefreshToken = _refreshToken,
            Scope = _scope,
            ObtainedAt = _obtainedAt,
        };
    }

    public async Task<bool> LoadCachedAccessTokenAsync()
    {
        var cached = await _redisService.GetAsync(BlingConstants.BlingToken);
        if (cached is null)
        {
            return false;
        }
        SetTokenData(JsonSerializer.Deserialize<BlingAccessTokenResponseDto>(cached, JsonOptions));
        return true;
    }

    public async Task<bool> SaveTokenToCacheAsync(BlingAccessTokenResponseDto? tokenData)
    {
        if (tokenData is null)
        {
            return false;
        }
        await _redisService.SetAsync(
            BlingConstants.BlingToken,
            JsonSerializer.Serialize(tokenData, JsonOptions),
            CacheDurations.BlingToken
        );
        return true;
    }
}
