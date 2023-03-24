namespace Kitchen.Dal.Interfaces;

public interface IRecipeRepo
{
    Task<IEnumerable<Recipe>> GetRecipesAsync(int limit, DateTime fromDate);
    Task<Recipe?> GetRecipeByIdAsync(Guid id);
    Task<bool> CreateRecipeAsync(Recipe recipe);
    Task<bool> UpdateRecipeAsync(Guid id, Recipe recipe);
    Task<bool> DeleteRecipeAsync(Guid id);
}
