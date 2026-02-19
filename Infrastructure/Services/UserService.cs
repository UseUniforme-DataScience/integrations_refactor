using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<User> GetUserAsync(string email, string password)
    {
        var user =
            await userRepository.GetUserByEmailAsync(email)
            ?? throw new InvalidOperationException("User not found");

        var passwordHasher = new PasswordHasher<User>();
        var passwordVerificationResult = passwordHasher.VerifyHashedPassword(
            user: user,
            hashedPassword: user.Password,
            providedPassword: password
        );
        if (passwordVerificationResult == PasswordVerificationResult.Failed)
            throw new InvalidOperationException("Invalid password");
        return user;
    }

    public async Task<User> CreateUserAsync(User user)
    {
        var passwordHasher = new PasswordHasher<User>();
        user.Password = passwordHasher.HashPassword(user, user.Password);
        try
        {
            return await userRepository.AddUserAsync(user);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Failed to create user");
        }
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        try
        {
            return await userRepository.UpdateUserAsync(user);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Failed to update user");
        }
    }

    public async Task<bool> DeleteUserAsync(long id)
    {
        try
        {
            return await userRepository.DeleteUserAsync(id);
        }
        catch (Exception)
        {
            throw new InvalidOperationException("Failed to delete user");
        }
    }
}
