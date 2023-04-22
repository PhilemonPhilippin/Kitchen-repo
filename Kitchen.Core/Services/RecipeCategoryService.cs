
namespace Kitchen.Core.Services;

public class RecipeCategoryService : IRecipeCategoryService
{
    private readonly IRecipeCategoryRepo _recipeCategoryRepo;

    public RecipeCategoryService(IRecipeCategoryRepo recipeCategoryRepo)
    {
        _recipeCategoryRepo = recipeCategoryRepo;
    }


    public async Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync()
    {
        IEnumerable<RecipeCategory> recipeCategories = await _recipeCategoryRepo.GetRecipeCategoriesAsync();

        return recipeCategories;
    }

    public async Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id)
    {
        RecipeCategory? recipeCategory = await _recipeCategoryRepo.GetRecipeCategoryByIdAsync(id);

        return recipeCategory;
    }

    public async Task<RecipeCategory?> CreateRecipeCategoryAsync(CreateRecipeCategoryRequest createRecipeCategoryRequest)
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
        {
            return null;
        }

        return recipeCategory;
    }

    public async Task<bool> UpdateRecipeCategoryAsync(Guid id, UpdateRecipeCategoryRequest updateRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Title = updateRecipeCategoryRequest.Title,
            Description = updateRecipeCategoryRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        bool isUpdated = await _recipeCategoryRepo.UpdateRecipeCategoryAsync(id, recipeCategory);
        return isUpdated;
    }

    public async Task<bool> DeleteRecipeCategoryAsync(Guid id)
    {
        bool isDeleted = await _recipeCategoryRepo.DeleteRecipeCategoryAsync(id);
        return isDeleted;
    }
}
