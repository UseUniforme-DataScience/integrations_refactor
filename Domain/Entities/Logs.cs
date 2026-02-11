namespace Domain.Entities;

public class Logs
{
    public required long Id { get; set; }
    public required string Level { get; set; }
    public string? Source { get; set; }
    public string? Message { get; set; }
    public string? Details { get; set; }
    public string? Parameters { get; set; }
    public string? Related { get; set; }
    public bool? Success { get; set; }
    public short? StatusCode { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
