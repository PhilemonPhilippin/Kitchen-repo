namespace Kitchen.Core.Interfaces;

public interface IRecipeCategoryService
{
    Task<IEnumerable<RecipeCategory>> GetAll();
    Task<DbResult<RecipeCategory>> Get(int id);
    Task<DbResult<RecipeCategory>> Add(RecipeCategoryRequest createRecipeCategoryRequest);
    Task<Status> Update(int id, RecipeCategoryRequest updateRecipeCategoryRequest);
    Task<Status> Delete(int id);
}
