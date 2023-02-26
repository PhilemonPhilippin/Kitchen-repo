namespace Kitchen.Api.Tools;

public static class ServicesDependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddDbContext<KitchenContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

        return services;
    }
}
