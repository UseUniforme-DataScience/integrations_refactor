using Application.Dtos.Bling.Token;

namespace Application.Interfaces.Bling;

public interface IBlingTokenService
{
    Task<BlingAccessTokenResponseDto?> GetTokenAsync(CancellationToken cancellationToken = default);
}
