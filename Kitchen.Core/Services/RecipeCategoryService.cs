
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
        return await _recipeCategoryRepo.GetRecipeCategoriesAsync();
    }
}
