namespace Kitchen.Dal.Interfaces;

public interface IRecipeIngredientRepo
{
    Task<IEnumerable<RecipeIngredient>> GetAll(int recipeId);
    Task<bool> Add(RecipeIngredient recipeIngredient);
    Task<DbResult<bool>> RecipeIngredientExist(RecipeIngredient recipeIngredient);
    Task<Status> Update(RecipeIngredient recipeIngredient);
    Task<Status> Delete(int recipeId, int ingredientId);
}
