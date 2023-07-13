namespace Kitchen.Dal.Interfaces;

public interface IRecipeRepo
{
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesAsync(int pageNumber, int pageSize);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesWithFilterAsync(
        int pageNumber, int pageSize, string title);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesWithSearchAsync(
        int pageNumber, int pageSize, string searchQuery);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesAsync(
        int pageNumber, int pageSize, string title, string searchQuery);
    Task<Recipe?> GetRecipeByIdAsync(int id);
    Task<bool> CreateRecipeAsync(Recipe recipe);
    Task<bool> UpdateRecipeAsync(Recipe recipe);
    Task<bool> DeleteRecipeAsync(int id);
    Task<bool> RecipeExistsAsync(int id);
}
