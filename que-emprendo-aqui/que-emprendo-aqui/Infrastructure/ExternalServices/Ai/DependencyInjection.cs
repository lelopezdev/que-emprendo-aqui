using Infrastructure.ExternalServices.Ai.Clients;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Options;
using OpenAI;

namespace Infrastructure.ExternalServices.Ai.options;

public static class DependencyInjection
{
    public static IServiceCollection AddAiGateway(
         this IServiceCollection services, IConfiguration config)
    {
        services.Configure<AiOptions>(config.GetSection("Ai"));

        services.AddSingleton(sp =>
        {
            var opts = sp.GetRequiredService<IOptions<AiOptions>>().Value;
            return new OpenAIClient(opts.ApiKey).GetChatClient(opts.Model).AsIChatClient();
        });

        services.AddScoped<IAiGateway, AiGateway>();
        return services;
    }
}
