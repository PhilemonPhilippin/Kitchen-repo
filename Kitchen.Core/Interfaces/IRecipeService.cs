
namespace Kitchen.Core.Interfaces;

public interface IRecipeService
{
    Task<List<Recipe>> GetRecipesAsync(int limit, DateTime fromDate);
    Task<Recipe> GetRecipeByIdAsync(Guid id);
    Task<Recipe> CreateRecipeAsync(CreateRecipeModel createRecipeModel);
    Task<bool> UpdateRecipeAsync(Guid id, UpdateRecipeModel updateRecipeModel);
    Task<bool> DeleteRecipeAsync(Guid id);
}
