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

    public async Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id) =>
        await _recipeCategoryRepo.GetRecipeCategoryByIdAsync(id);

    public async Task<RecipeCategory?> CreateRecipeCategoryAsync(RecipeCategoryRequest createRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Id = Guid.NewGuid(),
            Title = createRecipeCategoryRequest.Title,
            Description = createRecipeCategoryRequest.Description,
            CreatedOn = DateTime.UtcNow,
            ModifiedOn = DateTime.UtcNow
        };

        bool isCreated = await _recipeCategoryRepo.CreateRecipeCategoryAsync(recipeCategory);

        if (isCreated == false)
            return null;

        return recipeCategory;
    }

    public async Task<bool> UpdateRecipeCategoryAsync(Guid id, RecipeCategoryRequest updateRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Title = updateRecipeCategoryRequest.Title,
            Description = updateRecipeCategoryRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        return await _recipeCategoryRepo.UpdateRecipeCategoryAsync(id, recipeCategory);
    }

    public async Task<bool> DeleteRecipeCategoryAsync(Guid id) =>
        await _recipeCategoryRepo.DeleteRecipeCategoryAsync(id);
}
