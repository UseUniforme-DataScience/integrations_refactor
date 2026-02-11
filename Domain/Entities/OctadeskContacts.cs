namespace Domain.Entities;

public class OctadeskContacts
{
    public required string Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneContacts { get; set; }
    public string? Organization { get; set; }
    public string? CustomFields { get; set; }
    public string? ResponsibleId { get; set; }
    public string? ResponsibleName { get; set; }
    public string? ResponsibleEmail { get; set; }
}
