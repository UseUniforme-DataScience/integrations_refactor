namespace Domain.Entities;

public class OctadeskTickets
{
    public required string Id { get; set; }
    public long? Number { get; set; }
    public string? Cpf { get; set; }
    public string? MotivoDoContato { get; set; }
    public string? PhoneContacts { get; set; }
    public string? RequesterId { get; set; }
    public string? RequesterName { get; set; }
    public string? RequesterCustomFields { get; set; }
    public string? StatusName { get; set; }
    public string? PriorityName { get; set; }
    public string? AssignedName { get; set; }
    public string? ParticipatingAssignedNames { get; set; }
    public string? Summary { get; set; }
    public string? Tags { get; set; }
    public string? UpdatedByName { get; set; }
    public string? AppsCustomFields { get; set; }
    public string? TypeName { get; set; }
    public string? GroupName { get; set; }
    public string? CustomFields { get; set; }
    public DateTime? ResolutionDate { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
