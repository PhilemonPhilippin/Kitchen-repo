namespace Kitchen.Core.Interfaces;

public interface IRecipeCategoryService
{
    Task<IEnumerable<RecipeCategory>> GetAll();
    Task<RecipeCategory?> Get(int id);
    Task<RecipeCategory?> Add(RecipeCategoryRequest createRecipeCategoryRequest);
    Task<bool> Update(int id, RecipeCategoryRequest updateRecipeCategoryRequest);
    Task<bool> Delete(int id);
}
