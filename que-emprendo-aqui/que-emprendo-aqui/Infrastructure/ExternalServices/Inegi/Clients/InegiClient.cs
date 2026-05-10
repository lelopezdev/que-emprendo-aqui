using Infrastructure.ExternalServices.Inegi.Dtos;
using Infrastructure.ExternalServices.Inegi.Options;
using Microsoft.Extensions.Options;

namespace Infrastructure.ExternalServices.Inegi.Clients;
public sealed class InegiClient : IInegiClient
{
    private readonly HttpClient _httpClient;
    private readonly InegiOptions _options;

    public InegiClient(
        HttpClient httpClient,
        IOptions<InegiOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    public async Task<IReadOnlyCollection<InegiRestaurantDto>> GetRestaurantsAsync(double latitude, double longitude, CancellationToken cancellationToken = default)
    {
        var endpoint = $"consulta/buscar/restaurantes/{latitude},{longitude}/5000/{_options.Token}";

        var response = await _httpClient.GetAsync(endpoint,cancellationToken);

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<List<InegiRestaurantDto>>(cancellationToken: cancellationToken);

        return result ?? [];
    }

}
