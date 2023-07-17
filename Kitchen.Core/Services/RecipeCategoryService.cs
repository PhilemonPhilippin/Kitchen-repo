namespace Kitchen.Core.Services;

public class RecipeCategoryService : IRecipeCategoryService
{
    private readonly IRecipeCategoryRepository _recipeCategoryRepository;

    public RecipeCategoryService(IRecipeCategoryRepository recipeCategoryRepository)
    {
        _recipeCategoryRepository = recipeCategoryRepository;
    }

    public async Task<IEnumerable<RecipeCategory>> GetAll() =>
        await _recipeCategoryRepository.GetAll();

    public async Task<RecipeCategory?> Get(int id) =>
        await _recipeCategoryRepository.Get(id);

    public async Task<RecipeCategory?> Add(RecipeCategoryRequest createRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Title = createRecipeCategoryRequest.Title,
            Description = createRecipeCategoryRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        RecipeCategory? created = await _recipeCategoryRepository.Add(recipeCategory);
        return created;
    }

    public async Task<bool> Update(int id, RecipeCategoryRequest updateRecipeCategoryRequest)
    {
        RecipeCategory recipeCategory = new()
        {
            Id = id,
            Title = updateRecipeCategoryRequest.Title,
            Description = updateRecipeCategoryRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        return await _recipeCategoryRepository.Update(recipeCategory);
    }

    public async Task<bool> Delete(int id) =>
        await _recipeCategoryRepository.Delete(id);
}
