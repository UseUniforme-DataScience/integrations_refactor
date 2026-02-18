using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedrivePaginationDto
{
    [JsonPropertyName("start")]
    public int Start { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("more_items_in_collection")]
    public bool MoreItemsInCollection { get; set; }

    [JsonPropertyName("next_start")]
    public int? NextStart { get; set; }
}
