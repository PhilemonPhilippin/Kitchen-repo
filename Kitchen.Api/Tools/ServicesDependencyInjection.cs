using System.Text.Json.Serialization;

namespace Kitchen.Api.Tools;

public static class ServicesDependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers(options =>
            {
                options.ReturnHttpNotAcceptable = true;
            })
            .AddXmlDataContractSerializerFormatters();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddScoped<IRecipeRepo, RecipeRepo>();
        services.AddScoped<IRecipeCategoryRepo, RecipeCategoryRepo>();
        services.AddScoped<IPreparationStepRepo, PreparationStepRepo>();
        services.AddScoped<IRecipeIngredientRepo, RecipeIngredientRepo>();
        services.AddTransient<IRecipeService, RecipeService>();
        services.AddTransient<IPreparationStepService, PreparationStepService>();
        services.AddTransient<IRecipeCategoryService, RecipeCategoryService>();
        services.AddTransient<IRecipeIngredientService, RecipeIngredientService>();

        services.AddDbContext<KitchenContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}
