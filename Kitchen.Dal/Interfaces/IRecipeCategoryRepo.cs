namespace Kitchen.Dal.Interfaces;

public interface IRecipeCategoryRepo
{
    Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync();
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id);
    Task<bool> CreateRecipeCategoryAsync(RecipeCategory recipeCategory);
    Task<bool> UpdateRecipeCategoryAsync(Guid id, RecipeCategory recipeCategory);
}