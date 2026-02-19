using Domain.Entities;

namespace Domain.Interfaces;

public interface ITokenService
{
    object GenerateJwtTokenAsync(User user);
    Task<object> GenerateUserJwtTokenAsync(string email, string password);
}
