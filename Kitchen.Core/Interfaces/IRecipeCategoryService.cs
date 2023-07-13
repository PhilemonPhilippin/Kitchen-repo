namespace Kitchen.Core.Interfaces;

public interface IRecipeCategoryService
{
    Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync();
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(int id);
    Task<RecipeCategory?> CreateRecipeCategoryAsync(RecipeCategoryRequest createRecipeCategoryRequest);
    Task<bool> UpdateRecipeCategoryAsync(int id, RecipeCategoryRequest updateRecipeCategoryRequest);
    Task<bool> DeleteRecipeCategoryAsync(int id);
}
