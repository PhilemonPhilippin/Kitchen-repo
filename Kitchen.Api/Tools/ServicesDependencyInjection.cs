using System.Text.Json.Serialization;

namespace Kitchen.Api.Tools;

public static class ServicesDependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration, string AllowKitchenNG)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: AllowKitchenNG,
                policy =>
                {
                    policy.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithExposedHeaders("X-Pagination");
                });
        });

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
        services.AddScoped<IIngredientRepo, IngredientRepo>();
        services.AddScoped<IRecipeIngredientRepo, RecipeIngredientRepo>();
        services.AddTransient<IRecipeService, RecipeService>();
        services.AddTransient<IPreparationStepService, PreparationStepService>();
        services.AddTransient<IRecipeCategoryService, RecipeCategoryService>();
        services.AddTransient<IIngredientService, IngredientService>();
        services.AddTransient<IRecipeIngredientService, RecipeIngredientService>();

        services.AddDbContext<KitchenContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}
