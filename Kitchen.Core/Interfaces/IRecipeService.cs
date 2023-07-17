using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IRecipeService
{
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize, string? title, string? searchQuery);
    Task<Recipe?> Get(int id);
    Task<Recipe?> Add(RecipeRequest createRecipeRequest);
    Task<bool> Update(int id, RecipeRequest updateRecipeRequest);
    Task<bool> Delete(int id);
    Task<bool> IdExist(int id);
}
