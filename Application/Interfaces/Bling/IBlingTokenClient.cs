using Application.Dtos.Bling;

namespace Application.Interfaces.Bling;

public interface IBlingTokenClient
{
    Task<BlingAccessTokenResponseDto?> GetOrRefreshAccessTokenAsync(
        CancellationToken cancellationToken = default
    );
}
