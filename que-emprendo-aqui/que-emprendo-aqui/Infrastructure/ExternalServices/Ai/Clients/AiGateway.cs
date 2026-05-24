using Infrastructure.ExternalServices.Ai.options;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Options;

namespace Infrastructure.ExternalServices.Ai.Clients;

public class AiGateway : IAiGateway
{
    private readonly IChatClient _client;
    private readonly AiOptions _options;

    public AiGateway(IChatClient client, IOptions<AiOptions> options)
    {
        _client = client;
        _options = options.Value;
    }

    public async Task<string> AskAsync(string prompt, CancellationToken ct = default)
    {
        var messages = new List<ChatMessage>
          {
              new(ChatRole.System, _options.SystemPrompt),
              new(ChatRole.User, prompt)
          };

        var response = await _client.GetResponseAsync(messages, cancellationToken: ct);
        return response.Text ?? string.Empty;
    }

}
