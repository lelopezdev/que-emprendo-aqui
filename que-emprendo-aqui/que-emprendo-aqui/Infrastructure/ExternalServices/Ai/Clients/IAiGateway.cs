namespace Infrastructure.ExternalServices.Ai.Clients;
public interface IAiGateway
{
    Task<string> AskAsync(string prompt, CancellationToken ct = default);
}

