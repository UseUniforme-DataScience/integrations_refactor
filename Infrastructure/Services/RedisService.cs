using Domain.Interfaces;
using StackExchange.Redis;

namespace Infrastructure.Services;

public class RedisService(IConnectionMultiplexer connectionMultiplexer) : IRedisService
{
    private readonly IDatabase _database = connectionMultiplexer.GetDatabase();

    public async Task<bool> SetAsync(string key, string value, TimeSpan? expiry = null)
    {
        if (expiry == TimeSpan.FromMinutes(0))
        {
            return true;
        }
        return await _database.StringSetAsync(key, value, expiry);
    }

    public async Task<string?> GetAsync(string key)
    {
        return await _database.StringGetAsync(key);
    }

    public async Task<bool> DeleteAsync(string key)
    {
        return await _database.KeyDeleteAsync(key);
    }
}
