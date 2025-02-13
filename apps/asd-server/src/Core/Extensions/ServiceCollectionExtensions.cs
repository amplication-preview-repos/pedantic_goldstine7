using Asd.APIs;

namespace Asd;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<ITestsService, TestsService>();
    }
}
