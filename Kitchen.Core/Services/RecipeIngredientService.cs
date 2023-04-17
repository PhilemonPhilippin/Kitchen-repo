
namespace Kitchen.Core.Services;

public class RecipeIngredientService : IRecipeIngredientService
{
    private readonly IRecipeIngredientRepo _recipeIngredientRepo;

    public RecipeIngredientService(IRecipeIngredientRepo recipeIngredientRepo)
    {
        _recipeIngredientRepo = recipeIngredientRepo;
    }
}
