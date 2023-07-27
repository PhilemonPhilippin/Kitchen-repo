namespace Kitchen.Core.Interfaces;

public interface IRecipeIngredientService
{
    Task<IEnumerable<RecipeIngredient>> GetAll(int recipeId);
    Task<bool> Add(int recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest);
    Task<Status> Update(int recipeId, int ingredientId, string ingredientQuantity);
    Task<Status> Delete(int recipeId, int ingredientId);
}
