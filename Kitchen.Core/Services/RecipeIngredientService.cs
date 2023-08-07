namespace Kitchen.Core.Services;

public class RecipeIngredientService : IRecipeIngredientService
{
    private readonly IRecipeIngredientRepo _recipeIngredientRepo;

    public RecipeIngredientService(IRecipeIngredientRepo recipeIngredientRepo)
    {
        _recipeIngredientRepo = recipeIngredientRepo;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetAll(int recipeId) =>
        await _recipeIngredientRepo.GetAll(recipeId);


    public async Task<bool> Add(int recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        RecipeIngredient recipeIngredient = new()
        {
            RecipeId = recipeId,
            IngredientId = (int)createRecipeIngredientRequest.IngredientId,
            IngredientQuantity = createRecipeIngredientRequest.IngredientQuantity,
            CreatedOn = DateTime.UtcNow,
            ModifiedOn = DateTime.UtcNow
        };

        DbResult<bool> dbResult = await _recipeIngredientRepo.RecipeIngredientExist(recipeIngredient);

        if (dbResult.Status == Status.Error || (dbResult.Status == Status.Success && dbResult.Entity == true))
            return false;
        
        return await _recipeIngredientRepo.Add(recipeIngredient);
    }

    public async Task<Status> Update(int recipeId, int ingredientId, string ingredientQuantity)
    {
        RecipeIngredient recipeIngredient = new()
        {
            IngredientId = ingredientId,
            RecipeId = recipeId,
            IngredientQuantity = ingredientQuantity,
            ModifiedOn = DateTime.UtcNow
        };

        return await _recipeIngredientRepo.Update(recipeIngredient);
    }

    public async Task<Status> Delete(int recipeId, int ingredientId) => await _recipeIngredientRepo.Delete(recipeId, ingredientId);

}
