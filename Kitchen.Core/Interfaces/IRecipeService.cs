using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IRecipeService
{
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesAsync(int pageNumber, int pageSize);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesAsync(
        int pageNumber, int pageSize, string? title, string? searchQuery);
    Task<Recipe?> GetRecipeByIdAsync(int id);
    Task<Recipe?> CreateRecipeAsync(RecipeRequest createRecipeRequest);
    Task<bool> UpdateRecipeAsync(int id, RecipeRequest updateRecipeRequest);
    Task<bool> DeleteRecipeAsync(int id);
    Task<bool> RecipeExistsAsync(int id);
}
