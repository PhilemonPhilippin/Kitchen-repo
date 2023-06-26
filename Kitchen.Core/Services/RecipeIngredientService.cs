namespace Kitchen.Core.Services;

public class RecipeIngredientService : IRecipeIngredientService
{
    private readonly IRecipeIngredientRepo _recipeIngredientRepo;

    public RecipeIngredientService(IRecipeIngredientRepo recipeIngredientRepo)
    {
        _recipeIngredientRepo = recipeIngredientRepo;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientAsync(Guid recipeId) =>
        await _recipeIngredientRepo.GetRecipeIngredientsAsync(recipeId);


    public async Task<bool> CreateRecipeIngredientAsync(Guid recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        RecipeIngredient recipeIngredient = new()
        {
            RecipeId = recipeId,
            IngredientId = createRecipeIngredientRequest.IngredientId,
            IngredientQuantity = createRecipeIngredientRequest.IngredientQuantity,
            CreatedOn = DateTime.UtcNow,
            ModifiedOn = DateTime.UtcNow
        };

        bool recipeIngredientExists = await _recipeIngredientRepo.RecipeIngredientExistsAsync(recipeIngredient);

        if (recipeIngredientExists)
            return false;

        return await _recipeIngredientRepo.CreateRecipeIngredientAsync(recipeIngredient);
    }

    public async Task<bool> UpdateRecipeIngredientAsync(Guid recipeId, Guid ingredientId, string ingredientQuantity)
    {
        RecipeIngredient recipeIngredient = new()
        {
            IngredientId = ingredientId,
            RecipeId = recipeId,
            IngredientQuantity = ingredientQuantity,
            ModifiedOn = DateTime.UtcNow
        };

        return await _recipeIngredientRepo.UpdateRecipeIngredientAsync(recipeIngredient);
    }

    public async Task<bool> DeleteRecipeIngredientAsync(Guid recipeId, Guid ingredientId) =>
        await _recipeIngredientRepo.DeleteRecipeIngredientAsync(recipeId, ingredientId);

}
