namespace DotNetImplicitConvert.Api.Configuration;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddTransient<IUserRepository, UserRepository>();
        return services;
    }
}