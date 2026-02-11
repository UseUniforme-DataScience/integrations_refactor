namespace Domain.Entities;

public class Blacklist
{
    public long Id { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }
    public string? Origin { get; set; }
    public DateTime? CreatedAt { get; set; }
}
