namespace Kitchen.Dal.Interfaces;

public interface IRecipeCategoryRepo
{
    Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync();
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(int id);
    Task<bool> CreateRecipeCategoryAsync(RecipeCategory recipeCategory);
    Task<bool> UpdateRecipeCategoryAsync(RecipeCategory recipeCategory);
    Task<bool> DeleteRecipeCategoryAsync(int id);
}