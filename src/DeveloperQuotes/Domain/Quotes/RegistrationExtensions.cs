namespace DeveloperQuotes.Domain.Quotes;

public static class RegistrationExtensions
{
    public static IServiceCollection AddQuotes(this IServiceCollection services)
    {
        _ = services.AddSingleton<QuoteFactory>();

        return services;
    }
}
