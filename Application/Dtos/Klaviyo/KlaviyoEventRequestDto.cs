using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.Dtos.Klaviyo;

public class KlaviyoEventRequestDto
{
    [MinLength(5)]
    [MaxLength(255)]
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("event_name")]
    [MinLength(3)]
    [MaxLength(50)]
    public string? EventName { get; set; }

    [JsonPropertyName("profile_properties")]
    public KlaviyoPropertiesDto? ProfileProperties { get; set; }

    [JsonPropertyName("event_properties")]
    public KlaviyoPropertiesDto? EventProperties { get; set; }
}
