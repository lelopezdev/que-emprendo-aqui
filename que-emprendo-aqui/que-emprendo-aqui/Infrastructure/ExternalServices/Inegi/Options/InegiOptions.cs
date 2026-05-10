namespace Infrastructure.ExternalServices.Inegi.Options;
public sealed class InegiOptions
{
    public const string SectionName = "Inegi";

    public string BaseUrl { get; set; } = default!;
    public string Token { get; set; } = default!;
}
