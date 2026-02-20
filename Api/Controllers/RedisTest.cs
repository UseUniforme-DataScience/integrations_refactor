using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RedisTest(IRedisService redisService) : ControllerBase
{
    [HttpPost("set")]
    public async Task<IActionResult> SetAsync([FromQuery] string key, [FromQuery] string value)
    {
        var response = await redisService.SetAsync(key, value);
        return Ok(new { cached = response });
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAsync([FromQuery] string key)
    {
        var response = await redisService.GetAsync(key);
        return Ok(new { key = key.ToLower(), value = response });
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteAsync([FromQuery] string key)
    {
        var response = await redisService.DeleteAsync(key);
        return Ok(new { deleted = response });
    }
}
