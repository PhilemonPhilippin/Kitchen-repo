
namespace Kitchen.Dal.Interfaces;

public interface IRecipeIngredientRepo
{
    Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientsAsync(Guid recipeId);
}
