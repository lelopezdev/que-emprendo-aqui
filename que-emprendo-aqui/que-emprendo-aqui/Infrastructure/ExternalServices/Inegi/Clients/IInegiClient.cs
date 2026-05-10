using Infrastructure.ExternalServices.Inegi.Dtos;

namespace Infrastructure.ExternalServices.Inegi.Clients;
public interface IInegiClient
{
    Task<IReadOnlyCollection<InegiRestaurantDto>> GetRestaurantsAsync(
        double latitude,
        double longitude,
        CancellationToken cancellationToken = default);
}
