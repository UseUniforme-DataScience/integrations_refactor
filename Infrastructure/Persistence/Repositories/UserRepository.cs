using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    public async Task<User> AddUserAsync(User user, CancellationToken cancellationToken = default)
    {
        await context.Users.AddAsync(user, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        return user;
    }

    public async Task<User?> GetUserByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        return await context.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<User?> GetUserByEmailAsync(
        string email,
        CancellationToken cancellationToken = default
    )
    {
        return await context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }

    public async Task<User> UpdateUserAsync(
        User user,
        CancellationToken cancellationToken = default
    )
    {
        var existingUser =
            await context.Users.FirstOrDefaultAsync(x => x.Id == user.Id, cancellationToken)
            ?? throw new InvalidOperationException($"User {user.Id} not found in database.");
        context.Entry(existingUser).CurrentValues.SetValues(user);
        await context.SaveChangesAsync(cancellationToken);
        return user;
    }

    public async Task<bool> DeleteUserAsync(long id, CancellationToken cancellationToken = default)
    {
        var user =
            await context.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken)
            ?? throw new InvalidOperationException($"User {id} not found in database.");
        context.Users.Remove(user);
        await context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
