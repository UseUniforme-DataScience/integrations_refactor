using Application.Dtos.Bling;

namespace Application.Interfaces.Bling;

public interface IBlingTokenService
{
    Task<BlingAccessTokenResponseDto?> GetTokenAsync(CancellationToken cancellationToken = default);
}
