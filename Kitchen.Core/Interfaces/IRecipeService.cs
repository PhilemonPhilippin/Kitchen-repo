namespace Kitchen.Core.Interfaces;

public interface IRecipeService
{
    Task<List<Recipe>> GetRecipesAsync(int limit, DateTime fromDate);
    Task<Recipe> GetRecipeByIdAsync(Guid id);
    Task<Recipe> CreateRecipeAsync(CreateRecipeRequest createRecipeRequest);
    Task<bool> UpdateRecipeAsync(Guid id, UpdateRecipeRequest updateRecipeRequest);
    Task<bool> DeleteRecipeAsync(Guid id);
}
