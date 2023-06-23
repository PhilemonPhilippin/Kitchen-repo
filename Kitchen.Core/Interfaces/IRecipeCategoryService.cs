namespace Kitchen.Core.Interfaces;

public interface IRecipeCategoryService
{
    Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync();
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id);
    Task<RecipeCategory?> CreateRecipeCategoryAsync(RecipeCategoryRequest createRecipeCategoryRequest);
    Task<bool> UpdateRecipeCategoryAsync(Guid id, RecipeCategoryRequest updateRecipeCategoryRequest);
    Task<bool> DeleteRecipeCategoryAsync(Guid id);
}
