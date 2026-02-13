using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

// response for list of deals
// /deals/list
public class PipedriveDealsListResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveDealListResponseDto> Data { get; set; } = [];

    [JsonPropertyName("additional_data")]
    public PipedriveDealAdditionalDataDto AdditionalData { get; set; } = new();

    [JsonPropertyName("related_objects")]
    public PipedriveDealRelatedObjectsDto? RelatedObjects { get; set; }
}

public class PipedriveDealAdditionalDataDto
{
    [JsonPropertyName("pagination")]
    public PipedrivePaginationDto? Pagination { get; set; }

    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; set; }
}

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

public class PipedriveDealRelatedObjectsDto
{
    [JsonPropertyName("user")]
    public Dictionary<string, PipedriveUserDto>? User { get; set; }

    [JsonPropertyName("person")]
    public Dictionary<string, PipedrivePersonListDto>? Person { get; set; }

    [JsonPropertyName("organization")]
    public Dictionary<string, PipedriveOrganizationDto>? Organization { get; set; }
}

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

public class PipedriveOrganizationDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("people_count")]
    public int PeopleCount { get; set; }

    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("cc_email")]
    public string? CcEmail { get; set; }
}
