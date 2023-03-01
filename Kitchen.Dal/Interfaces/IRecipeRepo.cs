namespace Kitchen.Dal.Interfaces;

public interface IRecipeRepo
{
    Task<List<Recipe>> GetRecipesAsync(int limit, DateTime fromDate);
    Task<Recipe> GetRecipeByIdAsync(Guid id);
}
