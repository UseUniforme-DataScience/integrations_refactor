using Application.Dtos.Bling.Token;

namespace Application.Interfaces.Bling;

public interface IBlingTokenClient
{
    Task<BlingAccessTokenResponseDto?> GetOrRefreshAccessTokenAsync(
        CancellationToken cancellationToken = default
    );
}
