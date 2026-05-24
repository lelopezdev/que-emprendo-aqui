namespace Infrastructure.ExternalServices.Ai.options;

public sealed class AiOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public string Model { get; set; } = "gpt-4o-mini";
    public string SystemPrompt { get; set; } = "Eres un asesor de negocios para México.";
}
