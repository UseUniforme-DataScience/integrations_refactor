// using System.Net.Cache;
// using System.Net.Http.Headers;
// using System.Net.Http.Json;
// using System.Text;
// using System.Text.Json;
// using Application.Dtos.Bling;
// using Application.Interfaces.Bling;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Options;

// namespace Infrastructure.Http.Bling
// {
//     public class BlingClient : IBlingClient
//     {
//         private HttpClient _httpClient;
//         private BlingOptions _options;
//         private string _clientIdAndSecretBase64;
//         private string _baseUrl;
//         private string _codeUrl;
//         private string _clientId;
//         private string _clientSecret;
//         private string _code;
//         private string _tokenBaseUrl;
//         private static readonly JsonSerializerOptions JsonOptions = new()
//         {
//             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
//             PropertyNameCaseInsensitive = true,
//         };

//         public BlingClient(
//             HttpClient httpClient,
//             IOptions<BlingOptions> options,
//             IConfiguration configuration
//         )
//         {
//             _code = GetCodeAsync().GetAwaiter().GetResult();

//             _options = options.Value;

//             _httpClient.BaseAddress = new Uri(_baseUrl + "/");
//             _httpClient.DefaultRequestHeaders.Add(
//                 "Authorization",
//                 $"Bearer {_options.AccessToken}"
//             );
//             _httpClient.DefaultRequestHeaders.Accept.Add(
//                 new MediaTypeWithQualityHeaderValue("application/json")
//             );
//         }

//         public Task<BlingLogisticResponseDto?> GetLogisticAsync(
//             long logisticId,
//             CancellationToken cancellationToken = default
//         )
//         {
//             throw new NotImplementedException();
//         }

//         public Task<BlingNfeResponseDto?> GetNfeAsync(
//             long nfeId,
//             CancellationToken cancellationToken = default
//         )
//         {
//             throw new NotImplementedException();
//         }

//         public Task<BlingOrderResponseDto?> GetOrderAsync(
//             long id,
//             CancellationToken cancellationToken = default
//         )
//         {
//             throw new NotImplementedException();
//         }
//     }
// }
