using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Services;

public class TokenService(IConfiguration configuration, IUserService userService) : ITokenService
{
    public object GenerateJwtTokenAsync(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(
            configuration["Authentication:PrivateKey"]
                ?? throw new InvalidOperationException("Private key is not configured")
        );

        var claims = new ClaimsIdentity();

        claims.AddClaims([new Claim("id", user.Id.ToString())]);
        claims.AddClaims([new Claim("email", user.Email)]);
        claims.AddClaims([new Claim("name", user.Name)]);

        foreach (var role in user.Roles ?? [])
        {
            claims.AddClaims([new Claim(ClaimTypes.Role, role)]);
        }

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = claims,
            Expires = DateTime.UtcNow.AddHours(6),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature
            ),
            TokenType = "Bearer",
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return new
        {
            access_token = tokenHandler.WriteToken(token),
            token_type = "Bearer",
            expires_at = tokenDescriptor.Expires?.ToUniversalTime(),
            roles = string.Join(",", user.Roles ?? []),
        };
    }

    public async Task<object> GenerateUserJwtTokenAsync(string email, string password)
    {
        try
        {
            var user = await userService.GetUserAsync(email, password);
            return GenerateJwtTokenAsync(user);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Failed to generate user JWT token");
        }
    }
}
