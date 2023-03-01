
namespace Kitchen.Core.Interfaces;

public interface IRecipeService
{
    Task<List<Recipe>> GetRecipesAsync(int limit, DateTime fromDate);
    Task<Recipe> GetRecipeByIdAsync(Guid id);
    Task<Recipe> CreateRecipe(CreateRecipeModel createRecipeModel);
}
