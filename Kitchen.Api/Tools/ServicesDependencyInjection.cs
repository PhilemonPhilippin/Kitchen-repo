using System.Text.Json.Serialization;

namespace Kitchen.Api.Tools;

public static class ServicesDependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddControllers();
            // Prevent json from cycling to infinite
            //.AddJsonOptions(options =>
            //{
            //    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            //});

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddScoped<IRecipeRepo, RecipeRepo>();
        services.AddTransient<IRecipeService, RecipeService>();

        services.AddDbContext<KitchenContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

        return services;
    }
}
