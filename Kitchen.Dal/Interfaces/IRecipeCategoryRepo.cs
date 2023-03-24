namespace Kitchen.Dal.Interfaces;

public interface IRecipeCategoryRepo
{
    Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id);
}