namespace Kitchen.Core.Services;

public class RecipeCategoryService : IRecipeCategoryService
{
    private readonly IRecipeCategoryRepo _recipeCategoryRepo;

    public RecipeCategoryService(IRecipeCategoryRepo recipeCategoryRepo)
    {
        _recipeCategoryRepo = recipeCategoryRepo;
    }


    public async Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync() =>
        await _recipeCategoryRepo.GetRecipeCategoriesAsync();

    public async Task<RecipeCategory?> GetRecipeCategoryByIdAsync(int id) =>
        await _recipeCategoryRepo.GetRecipeCategoryByIdAsync(id);

    public async Task<RecipeCategory?> CreateRecipeCategoryAsync(RecipeCategoryRequest createRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Title = createRecipeCategoryRequest.Title,
            Description = createRecipeCategoryRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        bool isCreated = await _recipeCategoryRepo.CreateRecipeCategoryAsync(recipeCategory);

        if (isCreated == false)
            return null;

        return recipeCategory;
    }

    public async Task<bool> UpdateRecipeCategoryAsync(int id, RecipeCategoryRequest updateRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Id = id,
            Title = updateRecipeCategoryRequest.Title,
            Description = updateRecipeCategoryRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        return await _recipeCategoryRepo.UpdateRecipeCategoryAsync(recipeCategory);
    }

    public async Task<bool> DeleteRecipeCategoryAsync(int id) =>
        await _recipeCategoryRepo.DeleteRecipeCategoryAsync(id);
}
