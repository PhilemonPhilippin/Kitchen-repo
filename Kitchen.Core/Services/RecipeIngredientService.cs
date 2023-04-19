namespace Kitchen.Core.Services;

public class RecipeIngredientService : IRecipeIngredientService
{
    private readonly IRecipeIngredientRepo _recipeIngredientRepo;

    public RecipeIngredientService(IRecipeIngredientRepo recipeIngredientRepo)
    {
        _recipeIngredientRepo = recipeIngredientRepo;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientAsync(Guid recipeId)
    {
        return await _recipeIngredientRepo.GetRecipeIngredientsAsync(recipeId);
    }
}
