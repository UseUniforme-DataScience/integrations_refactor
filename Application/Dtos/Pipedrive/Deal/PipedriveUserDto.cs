using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Deal;

public class PipedriveUserDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("has_pic")]
    public int HasPic { get; set; }

    [JsonPropertyName("pic_hash")]
    public string? PicHash { get; set; }

    [JsonPropertyName("active_flag")]
    public bool ActiveFlag { get; set; }
}
