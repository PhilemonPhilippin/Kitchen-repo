namespace Kitchen.Dal.Interfaces;

public interface IRecipeCategoryRepo
{
    Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync();
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id);
}