using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Kitchen.Api.Tools;

public static class ServicesDependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                policy =>
                {
                    policy.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithExposedHeaders("X-Pagination");
                });
        });

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.Authority = "https://philauth.eu.auth0.com/";
            options.Audience = "https://localhost:7049/api";
        });

        services.AddControllers(options =>
            {
                options.ReturnHttpNotAcceptable = true;
            })
            .AddXmlDataContractSerializerFormatters();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddTransient<IRecipeRepository, RecipeRepository>();
        services.AddTransient<IRecipeCategoryRepository, RecipeCategoryRepository>();
        services.AddTransient<IIngredientRepository, IngredientRepository>();
        services.AddTransient<IRecipeIngredientRepo, RecipeIngredientRepo>();
        services.AddTransient<IPreparationStepRepository, PreparationStepRepository>();

        // Choose main DataBase all the time, except when updating Test DataBase is required. If so, choose second.
        // Use this main connection string for the DataBase Kitchen.
        string databaseToUse = "KitchenConnectionString";

        //// Use this second connection string to Update-Database for the test DataBase "KitchenTest".
        //// Comment first databaseToUse and uncomment the second.
        //// Then run the Update-Database nuGet command, then reverse the comments.
        //string databaseToUse = "KitchenTestConnectionString";

        string connectionString = Environment.GetEnvironmentVariable(databaseToUse, EnvironmentVariableTarget.User) ?? "Environment variable for Database connection string not found.";
        services.AddDbContext<KitchenContext>(options => options.UseSqlServer(connectionString));


        services.AddHealthChecks();

        return services;
    }
}
