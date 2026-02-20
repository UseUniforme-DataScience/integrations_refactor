namespace Domain.Interfaces;

public interface IRedisService
{
    Task<bool> SetAsync(string key, string value, TimeSpan? expiry = null);
    Task<string?> GetAsync(string key);
    Task<bool> DeleteAsync(string key);
}
