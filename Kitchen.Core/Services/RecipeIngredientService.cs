using Kitchen.Contracts.Requests;
using Kitchen.Entities;

namespace Kitchen.Core.Services;

public class RecipeIngredientService : IRecipeIngredientService
{
    private readonly IRecipeIngredientRepo _recipeIngredientRepo;
    private readonly IIngredientRepo _ingredientRepo;

    public RecipeIngredientService(IRecipeIngredientRepo recipeIngredientRepo, IIngredientRepo ingredientRepo)
    {
        _recipeIngredientRepo = recipeIngredientRepo;
        _ingredientRepo = ingredientRepo;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientAsync(Guid recipeId)
    {
        return await _recipeIngredientRepo.GetRecipeIngredientsAsync(recipeId);
    }

    public async Task<bool> CreateRecipeIngredientAsync(Guid recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        bool isCreated;

        if (createRecipeIngredientRequest.Id == null)
        {
            isCreated = await CreateIngredientAndRecipeIngredientAsync(recipeId, createRecipeIngredientRequest);
        }
        else
        {
            isCreated = await CreateOnlyRecipeIngredientAsync(recipeId, createRecipeIngredientRequest);
        }

        return isCreated;
    }

    private async Task<bool> CreateIngredientAndRecipeIngredientAsync(
        Guid recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Id = Guid.NewGuid(),
            Name = createRecipeIngredientRequest.Name,
            Description = createRecipeIngredientRequest.Description
        };

        bool isIngredientCreated = await _ingredientRepo.CreateIngredientAsync(ingredient);

        if (isIngredientCreated == false)
        {
            return false;
        }

        RecipeIngredient recipeIngredient = new()
        {
            RecipeId = recipeId,
            IngredientId = ingredient.Id,
            IngredientQuantity = createRecipeIngredientRequest.IngredientQuantity
        };

        bool isCreated = await _recipeIngredientRepo.CreateRecipeIngredientAsync(recipeIngredient);
        return isCreated;
    }

    private async Task<bool> CreateOnlyRecipeIngredientAsync(
        Guid recipeId, CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        RecipeIngredient recipeIngredient = new()
        {
            RecipeId = recipeId,
            IngredientId = (Guid)createRecipeIngredientRequest.Id,
            IngredientQuantity = createRecipeIngredientRequest.IngredientQuantity
        };

        bool recipeIngredientExists = await _recipeIngredientRepo.RecipeIngredientExistsAsync(recipeIngredient);

        if (recipeIngredientExists)
        {
            return false;
        }

        bool isCreated = await _recipeIngredientRepo.CreateRecipeIngredientAsync(recipeIngredient);
        return isCreated;
    }
}
