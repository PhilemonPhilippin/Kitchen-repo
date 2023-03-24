namespace Kitchen.Core.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepo _recipeRepo;
    private readonly IRecipeCategoryRepo _recipeCategoryRepo;
    const int maxLimit = 25;

    public RecipeService(IRecipeRepo recipeRepo, IRecipeCategoryRepo recipeCategoryRepo)
    {
        _recipeRepo = recipeRepo;
        _recipeCategoryRepo = recipeCategoryRepo;
    }

    public async Task<IEnumerable<Recipe>> GetRecipesAsync(int limit, DateTime fromDate)
    {
        if (limit > maxLimit)
            limit = maxLimit;

        IEnumerable<Recipe> recipes = await _recipeRepo.GetRecipesAsync(limit, fromDate);

        return recipes;
    }

    public async Task<Recipe?> GetRecipeByIdAsync(Guid id)
    {
        Recipe recipe = await _recipeRepo.GetRecipeByIdAsync(id);

        return recipe;
    }

    public async Task<Recipe?> CreateRecipeAsync(CreateRecipeRequest createRecipeRequest)
    {
        Recipe recipe = new()
        {
            Id = Guid.NewGuid(),
            Title = createRecipeRequest.Title,
            Description = createRecipeRequest.Description,
            RecipeCategoryId = createRecipeRequest.RecipeCategoryId,
            CreatedOn = DateTime.UtcNow
        };

        bool isCreated = await _recipeRepo.CreateRecipeAsync(recipe);

        if (isCreated == false)
        {
            // TODO: Return something else than null to notify i did not create with success
            return null;
        }
        else
        {
            // TODO: Check for null recipeCategory maybe?
            RecipeCategory? category = await _recipeCategoryRepo.GetRecipeCategoryByIdAsync(createRecipeRequest.RecipeCategoryId);

            recipe.RecipeCategory = category;

            return recipe;
        }
    }

    public async Task<bool> UpdateRecipeAsync(Guid id, UpdateRecipeRequest updateRecipeRequest)
    {
        Recipe recipe = new()
        {
            Title = updateRecipeRequest.Title,
            Description = updateRecipeRequest.Description,
            RecipeCategoryId = updateRecipeRequest.RecipeCategoryId,
        };

        bool isUpdated = await _recipeRepo.UpdateRecipeAsync(id, recipe);

        return isUpdated;
    }

    public async Task<bool> DeleteRecipeAsync(Guid id)
    {
        return await _recipeRepo.DeleteRecipeAsync(id);
    }
}
