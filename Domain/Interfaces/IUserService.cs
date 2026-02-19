using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserService
{
    Task<User> GetUserAsync(string email, string password);
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(long id);
}
