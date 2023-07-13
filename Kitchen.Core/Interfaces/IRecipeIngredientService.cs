namespace Kitchen.Core.Interfaces;

public interface IRecipeIngredientService
{
    Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientAsync(int recipeId);
    Task<bool> CreateRecipeIngredientAsync(int recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest);
    Task<bool> UpdateRecipeIngredientAsync(int recipeId, int ingredientId, string ingredientQuantity);
    Task<bool> DeleteRecipeIngredientAsync(int recipeId, int ingredientId);
}
