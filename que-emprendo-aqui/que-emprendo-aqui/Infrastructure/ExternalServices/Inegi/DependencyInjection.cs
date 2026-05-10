using Infrastructure.ExternalServices.Inegi.Clients;
using Infrastructure.ExternalServices.Inegi.Options;
using Microsoft.Extensions.Options;

namespace Infrastructure.ExternalServices.Inegi;
public static class DependencyInjection
{
    public static IServiceCollection AddInegi(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<InegiOptions>(configuration.GetSection(InegiOptions.SectionName));

        services.AddHttpClient<IInegiClient, InegiClient>((sp, client) =>
        {
            var options = sp.GetRequiredService<IOptions<InegiOptions>>().Value;

            client.BaseAddress = new Uri(options.BaseUrl);

            client.Timeout = TimeSpan.FromSeconds(30);
        });

        return services;
    }
}
