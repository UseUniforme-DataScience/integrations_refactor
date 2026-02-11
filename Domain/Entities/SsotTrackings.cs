namespace Domain.Entities;

public class SsotTracking
{
    public required long OrderId { get; set; }
    public required string Id { get; set; }
    public string? LakeOriginTrackingId { get; set; }
    public string? CarrierSource { get; set; }
    public string? CarrierId { get; set; }
    public string? CarrierName { get; set; }
    public DateTime? CreatedAt { get; set; }
    public string? TrackingCode { get; set; }
    public long? TrackingId { get; set; }
    public string? TrackingName { get; set; }
    public string? TrackingDescription { get; set; }
    public long? DaysToTrackingStatus { get; set; }
    public DateTime? UseCreatedAt { get; set; }
}
