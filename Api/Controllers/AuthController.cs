using Application.Dtos.Auth;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(ITokenService tokenService, IUserService userService) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
    {
        try
        {
            var token = await tokenService.GenerateUserJwtTokenAsync(
                request.Email,
                request.Password
            );
            return Ok(token);
        }
        catch (Exception)
        {
            return BadRequest(new { error = "Failed to login" });
        }
    }

    [HttpPost("swagger-login")]
    [Consumes("application/x-www-form-urlencoded")]
    public async Task<IActionResult> SwaggerLogin(
        [FromForm] string username,
        [FromForm] string password
    )
    {
        try
        {
            var token = await tokenService.GenerateUserJwtTokenAsync(username, password);
            return Ok(token);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return BadRequest(new { error = "Failed to login" });
        }
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto request)
    {
        var user = new User
        {
            Name = request.Name,
            Email = request.Email,
            Password = request.Password,
            Roles = request.Roles,
            CreatedAt = request.CreatedAt,
            UpdatedAt = request.UpdatedAt,
        };
        try
        {
            var response = await userService.CreateUserAsync(user);
            return Ok(response);
        }
        catch (Exception)
        {
            return BadRequest(new { error = "Failed to create user" });
        }
    }
}
