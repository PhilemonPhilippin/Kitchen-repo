namespace Kitchen.Dal.Interfaces;

public interface IRecipeRepo
{
    Task<IEnumerable<Recipe>> GetRecipesAsync(int limit, DateTime fromDate);
    Task<IEnumerable<Recipe>> GetRecipesWithFilterAsync(int limit, DateTime fromDate, string title);
    Task<IEnumerable<Recipe>> GetRecipesWithSearchAsync(int limit, DateTime fromDate, string searchQuery);
    Task<IEnumerable<Recipe>> GetRecipesWithFilterAndSearchAsync(
        int limit, DateTime fromDate, string title, string searchQuery);
    Task<Recipe?> GetRecipeByIdAsync(Guid id);
    Task<bool> CreateRecipeAsync(Recipe recipe);
    Task<bool> UpdateRecipeAsync(Guid id, Recipe recipe);
    Task<bool> DeleteRecipeAsync(Guid id);
}
