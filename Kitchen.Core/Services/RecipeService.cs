namespace Kitchen.Core.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IRecipeCategoryRepository _recipeCategoryRepository;
    private const int _maxPageSize = 20;

    public RecipeService(IRecipeRepository recipeRepository, IRecipeCategoryRepository recipeCategoryRepository)
    {
        _recipeRepository = recipeRepository;
        _recipeCategoryRepository = recipeCategoryRepository;
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize, string? title, string? searchQuery)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        if (string.IsNullOrEmpty(title) == false && string.IsNullOrEmpty(searchQuery) == false)
        {
            title = title.Trim();
            searchQuery = searchQuery.Trim();
            return await _recipeRepository.GetPage(pageNumber, pageSize, title, searchQuery);
        }
        else if (string.IsNullOrEmpty(title) == false)
        {
            title = title.Trim();
            return await _recipeRepository.GetPageWithFilter(pageNumber, pageSize, title);
        }
        else if (string.IsNullOrEmpty(searchQuery) == false)
        {
            searchQuery = searchQuery.Trim();
            return await _recipeRepository.GetPageWithSearch(pageNumber, pageSize, searchQuery);
        }
        else
        {
            return await _recipeRepository.GetPage(pageNumber, pageSize);
        }
    }

    public async Task<DbResult<Recipe>> Get(int id) => await _recipeRepository.Get(id);


    public async Task<DbResult<Recipe>> Add(RecipeRequest createRecipeRequest)
    {
        Recipe recipe = new()
        {
            Title = createRecipeRequest.Title,
            Description = createRecipeRequest.Description,
            RecipeCategoryId = (int)createRecipeRequest.RecipeCategoryId,
            ModifiedOn = DateTime.UtcNow
        };

        bool categoryExist = await _recipeCategoryRepository.IdExist((int)createRecipeRequest.RecipeCategoryId);

        if (categoryExist == false)
            return new DbResult<Recipe> { Status = Status.NotFound};

        DbResult<Recipe> recipeDbResult = await _recipeRepository.Add(recipe);

        return recipeDbResult;
    }

    public async Task<Status> Update(int id, RecipeRequest updateRecipeRequest)
    {
        Recipe recipe = new()
        {
            Id = id,
            Title = updateRecipeRequest.Title,
            Description = updateRecipeRequest.Description,
            RecipeCategoryId = (int)updateRecipeRequest.RecipeCategoryId,
            ModifiedOn = DateTime.UtcNow
        };

        bool categoryExist = await _recipeCategoryRepository.IdExist((int)updateRecipeRequest.RecipeCategoryId);

        if (categoryExist == false)
            return Status.NotFound;

        return await _recipeRepository.Update(recipe);
    }

    public async Task<Status> Delete(int id) => await _recipeRepository.Delete(id);

    public async Task<bool> IdExist(int id) => await _recipeRepository.IdExist(id);

}
