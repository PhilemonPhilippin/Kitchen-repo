namespace Kitchen.Core.Interfaces;

public interface IRecipeIngredientService
{
    Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientAsync(Guid recipeId);
    Task<bool> CreateRecipeIngredientAsync(Guid recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest);
    Task<bool> UpdateRecipeIngredientAsync(Guid recipeId, Guid ingredientId, string ingredientQuantity);
    Task<bool> DeleteRecipeIngredientAsync(Guid recipeId, Guid ingredientId);
}
