using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Deal;

// response for list of deals
// /deals/list
public class PipedriveDealsListResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveDealListResponseDto> Data { get; set; } = [];

    [JsonPropertyName("additional_data")]
    public PipedriveAdditionalDataDto AdditionalData { get; set; } = new();

    [JsonPropertyName("related_objects")]
    public PipedriveDealRelatedObjectsDto? RelatedObjects { get; set; }
}
