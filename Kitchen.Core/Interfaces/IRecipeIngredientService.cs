namespace Kitchen.Core.Interfaces;

public interface IRecipeIngredientService
{
    Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientAsync(Guid recipeId);
}
