namespace Kitchen.Core.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepo _recipeRepo;
    public RecipeService(IRecipeRepo recipeRepo)
    {
        _recipeRepo = recipeRepo;
    }

    public async Task<List<Recipe>> GetRecipesAsync(int limit, DateTime fromDate)
    {
        if (limit > 25)
        {
            limit = 25;
        }

        List<Recipe> recipes = await _recipeRepo.GetRecipesAsync(limit, fromDate);

        return recipes;
    }
}
