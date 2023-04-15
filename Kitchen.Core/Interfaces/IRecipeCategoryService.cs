
namespace Kitchen.Core.Interfaces;

public interface IRecipeCategoryService
{
    Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync();
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id);
    Task<RecipeCategory?> CreateRecipeCategoryAsync(CreateRecipeCategoryRequest createRecipeCategoryRequest);
    Task<bool> UpdateRecipeCategoryAsync(Guid id, UpdateRecipeCategoryRequest updateRecipeCategoryRequest);
    Task<bool> DeleteRecipeCategoryAsync(Guid id);
}
