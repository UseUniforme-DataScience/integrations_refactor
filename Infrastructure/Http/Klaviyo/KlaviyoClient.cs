using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Application.Dtos.Klaviyo;
using Application.Interfaces.Klaviyo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Http.Klaviyo;

public class KlaviyoClient : IKlaviyoClient
{
    private const int MaxRetries = 10;
    private const int InitialRetryDelaySeconds = 10;
    private readonly HttpClient _httpClient;
    private readonly ILogger<KlaviyoClient> _logger;
    private readonly string _baseUrl;

    public KlaviyoClient(
        HttpClient httpClient,
        IConfiguration configuration,
        ILogger<KlaviyoClient> logger
    )
    {
        _httpClient = httpClient;
        _logger = logger;

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Klaviyo-API-Key",
            configuration["Klaviyo:ApiKey"]
        );
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.api+json");
        _httpClient.DefaultRequestHeaders.Add("revision", "2025-07-15");

        _baseUrl =
            configuration["Klaviyo:BaseUrl"]
            ?? throw new InvalidOperationException("Klaviyo base URL is not configured");
    }

    public async Task<bool> SendEventAsync(
        KlaviyoEventRequestDto eventDto,
        CancellationToken cancellationToken = default
    )
    {
        var url = new Uri($"{_baseUrl}/events");

        var profileAttributes = new Dictionary<string, object>();
        if (!string.IsNullOrWhiteSpace(eventDto.Email))
            profileAttributes["email"] = eventDto.Email;
        if (!string.IsNullOrWhiteSpace(eventDto.PhoneNumber))
            profileAttributes["phone_number"] = eventDto.PhoneNumber;

        if (eventDto.ProfileProperties is not null)
        {
            var properties = eventDto.ProfileProperties.GetType().GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(eventDto.ProfileProperties);

                if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
                    continue;

                var jsonPropertyName =
                    property.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? property.Name;

                profileAttributes[jsonPropertyName] = value;
            }
        }

        var eventProperties = new Dictionary<string, object>();
        if (eventDto.EventProperties is not null)
        {
            var eventPropertiesData = eventDto.EventProperties.GetType().GetProperties();
            foreach (var property in eventPropertiesData)
            {
                var value = property.GetValue(eventDto.EventProperties);
                if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
                    continue;

                var jsonPropertyName =
                    property.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? property.Name;

                eventProperties[jsonPropertyName] = value;
            }
        }

        var body = new
        {
            data = new
            {
                type = "event",
                attributes = new
                {
                    metric = new
                    {
                        data = new
                        {
                            type = "metric",
                            attributes = new { name = eventDto.EventName },
                        },
                    },
                    properties = eventProperties,
                    profile = new
                    {
                        data = new { type = "profile", attributes = profileAttributes },
                    },
                },
            },
        };

        var response = await _httpClient.PostAsJsonAsync(url, body, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            var content =
                await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)
                ?? throw new InvalidOperationException("Failed to read response content");
            throw new Exception($"Failed to send event to Klaviyo: {content}");
        }

        return true;
    }

    public async Task SendEventsInBulkAsync(
        IReadOnlyList<KlaviyoEventRequestDto> events,
        int batchSize = 500,
        int requestsIntervalSeconds = 10,
        CancellationToken cancellationToken = default
    )
    {
        if (batchSize is < 100 or > 1000)
            throw new ArgumentOutOfRangeException(
                nameof(batchSize),
                "O tamanho do lote deve estar entre 100 e 1000!"
            );
        if (events is null || events.Count == 0)
            throw new ArgumentException("A lista de eventos não pode estar vazia.", nameof(events));

        var numBatches = (events.Count + batchSize - 1) / batchSize;
        _logger.LogInformation(
            "Iniciando envio de evento para o Klaviyo em {Time}",
            DateTime.UtcNow.ToString("o")
        );
        _logger.LogInformation(
            "Enviando {Count} eventos em {Batches} lotes de até {BatchSize}.",
            events.Count,
            numBatches,
            batchSize
        );

        for (var batchNum = 1; batchNum <= numBatches; batchNum++)
        {
            var start = (batchNum - 1) * batchSize;
            var batch = events.Skip(start).Take(batchSize).ToList();

            var eventBulkCreateData = new List<object>();

            foreach (var eventDto in batch)
            {
                if (
                    string.IsNullOrWhiteSpace(eventDto.Email)
                    && string.IsNullOrWhiteSpace(eventDto.PhoneNumber)
                )
                    continue;

                var profileAttributes = new Dictionary<string, object>(StringComparer.Ordinal);
                if (!string.IsNullOrWhiteSpace(eventDto.PhoneNumber))
                    profileAttributes["phone_number"] = eventDto.PhoneNumber;
                if (!string.IsNullOrWhiteSpace(eventDto.Email))
                    profileAttributes["email"] = eventDto.Email;
                if (eventDto.ProfileProperties is not null)
                {
                    var profileProps = ToDictionaryExcludingNulls(eventDto.ProfileProperties);
                    if (profileProps.Count > 0)
                        profileAttributes["properties"] = profileProps;
                }

                var eventProperties = eventDto.EventProperties is not null
                    ? ToDictionaryExcludingNulls(eventDto.EventProperties)
                    : new Dictionary<string, object>();

                var eventBulkCreate = new Dictionary<string, object>(StringComparer.Ordinal)
                {
                    ["type"] = "event-bulk-create",
                    ["attributes"] = new Dictionary<string, object>(StringComparer.Ordinal)
                    {
                        ["profile"] = new Dictionary<string, object>(StringComparer.Ordinal)
                        {
                            ["data"] = new Dictionary<string, object>(StringComparer.Ordinal)
                            {
                                ["type"] = "profile",
                                ["attributes"] = profileAttributes,
                            },
                        },
                        ["events"] = new Dictionary<string, object>(StringComparer.Ordinal)
                        {
                            ["data"] = new List<object>
                            {
                                new Dictionary<string, object>(StringComparer.Ordinal)
                                {
                                    ["type"] = "event",
                                    ["attributes"] = new Dictionary<string, object>(
                                        StringComparer.Ordinal
                                    )
                                    {
                                        ["metric"] = new Dictionary<string, object>(
                                            StringComparer.Ordinal
                                        )
                                        {
                                            ["data"] = new Dictionary<string, object>(
                                                StringComparer.Ordinal
                                            )
                                            {
                                                ["type"] = "metric",
                                                ["attributes"] = new Dictionary<string, object>(
                                                    StringComparer.Ordinal
                                                )
                                                {
                                                    ["name"] = eventDto.EventName ?? "",
                                                },
                                            },
                                        },
                                        ["properties"] = eventProperties,
                                    },
                                },
                            },
                        },
                    },
                };

                eventBulkCreateData.Add(eventBulkCreate);
            }

            if (eventBulkCreateData.Count == 0)
            {
                _logger.LogInformation(
                    "Lote {BatchNum}/{NumBatches} vazio. Nenhum evento enviado para o Klaviyo.",
                    batchNum,
                    numBatches
                );
                continue;
            }

            var data = new Dictionary<string, object>(StringComparer.Ordinal)
            {
                ["data"] = new Dictionary<string, object>(StringComparer.Ordinal)
                {
                    ["type"] = "event-bulk-create-job",
                    ["attributes"] = new Dictionary<string, object>(StringComparer.Ordinal)
                    {
                        ["events-bulk-create"] = new Dictionary<string, object>(
                            StringComparer.Ordinal
                        )
                        {
                            ["data"] = eventBulkCreateData,
                        },
                    },
                },
            };

            var delaySeconds = InitialRetryDelaySeconds;
            for (var attempt = 1; attempt <= MaxRetries; attempt++)
            {
                try
                {
                    var url = new Uri($"{_baseUrl}/event-bulk-create-jobs");
                    var json = JsonSerializer.Serialize(data);
                    var content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/vnd.api+json"
                    );
                    var response = await _httpClient
                        .PostAsync(url, content, cancellationToken)
                        .ConfigureAwait(false);

                    if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                    {
                        _logger.LogInformation(
                            "Lote {BatchNum}/{NumBatches} enviado com sucesso",
                            batchNum,
                            numBatches
                        );
                        _logger.LogInformation(
                            "Aguardando {Interval} segundos para o Klaviyo processar os eventos",
                            requestsIntervalSeconds
                        );
                        await Task.Delay(
                                TimeSpan.FromSeconds(requestsIntervalSeconds),
                                cancellationToken
                            )
                            .ConfigureAwait(false);
                        break;
                    }

                    var responseText = await response
                        .Content.ReadAsStringAsync(cancellationToken)
                        .ConfigureAwait(false);
                    _logger.LogWarning(
                        "Erro ao enviar lote {BatchNum}/{NumBatches} para o Klaviyo: {Response}. Tentando novamente em {Seconds} segundos",
                        batchNum,
                        numBatches,
                        responseText,
                        delaySeconds
                    );
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(
                        ex,
                        "Erro ao enviar lote {BatchNum}/{NumBatches} para o Klaviyo. Tentando novamente em {Seconds} segundos",
                        batchNum,
                        numBatches,
                        delaySeconds
                    );
                }

                if (attempt == MaxRetries)
                    throw new InvalidOperationException(
                        "Excedido o número de tentativas de envio."
                    );

                await Task.Delay(TimeSpan.FromSeconds(delaySeconds), cancellationToken)
                    .ConfigureAwait(false);
                delaySeconds += InitialRetryDelaySeconds;
            }
        }

        _logger.LogInformation(
            "Finalizado envio de eventos para o Klaviyo em {Time}",
            DateTime.UtcNow.ToString("o")
        );
    }

    private static Dictionary<string, object> ToDictionaryExcludingNulls(object obj)
    {
        var result = new Dictionary<string, object>(StringComparer.Ordinal);
        if (obj is null)
            return result;
        var properties = obj.GetType().GetProperties();
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
                continue;
            var name =
                property.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? property.Name;
            result[name] = value;
        }
        return result;
    }
}
