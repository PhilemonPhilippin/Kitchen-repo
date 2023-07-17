
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

        services.AddTransient<IRecipeRepo, RecipeRepo>();
        services.AddTransient<IRecipeCategoryRepository, RecipeCategoryRepository>();
        services.AddTransient<IIngredientRepo, IngredientRepo>();
        services.AddTransient<IRecipeIngredientRepo, RecipeIngredientRepo>();
        services.AddTransient<IPreparationStepRepository, PreparationStepRepository>();
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
