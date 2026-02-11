using Application.Dtos.Bling;
using Application.Interfaces.Bling;

namespace Application.Services.Bling;

public class BlingTokenService(IBlingTokenClient blingTokenClient) : IBlingTokenService
{
    public async Task<BlingAccessTokenResponseDto?> GetTokenAsync(
        CancellationToken cancellationToken = default
    ) =>
        await blingTokenClient
            .GetOrRefreshAccessTokenAsync(cancellationToken)
            .ConfigureAwait(false);
}
