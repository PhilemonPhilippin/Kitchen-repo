namespace Kitchen.Core.Interfaces;

public interface IRecipeService
{
    Task<IEnumerable<Recipe>> GetRecipesAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Recipe>> GetRecipesAsync(int pageNumber, int pageSize, string? title, string? searchQuery);
    Task<Recipe?> GetRecipeByIdAsync(Guid id);
    Task<Recipe?> CreateRecipeAsync(CreateRecipeRequest createRecipeRequest);
    Task<bool> UpdateRecipeAsync(Guid id, UpdateRecipeRequest updateRecipeRequest);
    Task<bool> DeleteRecipeAsync(Guid id);
}
