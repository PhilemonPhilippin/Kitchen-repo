namespace Kitchen.Dal.Interfaces;

public interface IRecipeIngredientRepo
{
    Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientsAsync(int recipeId);
    Task<bool> CreateRecipeIngredientAsync(RecipeIngredient recipeIngredient);
    Task<bool> RecipeIngredientExistsAsync(RecipeIngredient recipeIngredient);
    Task<bool> UpdateRecipeIngredientAsync(RecipeIngredient recipeIngredient);
    Task<bool> DeleteRecipeIngredientAsync(int recipeId, int ingredientId);
}
