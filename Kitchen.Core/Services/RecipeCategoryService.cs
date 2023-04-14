
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
}
