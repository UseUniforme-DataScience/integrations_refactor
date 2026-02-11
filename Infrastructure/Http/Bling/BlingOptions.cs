namespace Infrastructure.Http.Bling;

public class BlingOptions
{
    public const string SectionName = "Bling";
    public string AccessToken { get; set; } = null!;
    public int ExpiresIn { get; set; } = 0;
    public DateTime ObtainedAt { get; set; } = DateTime.UtcNow;
    public string RefreshToken { get; set; } = string.Empty;
    public string TokenType { get; set; } = string.Empty;
    public string Scope { get; set; } = string.Empty;
}
