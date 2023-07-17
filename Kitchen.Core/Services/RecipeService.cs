using Kitchen.Models;

namespace Kitchen.Core.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepo _recipeRepo;
    private readonly IRecipeCategoryRepository _recipeCategoryRepository;
    private const int _maxPageSize = 20;

    public RecipeService(IRecipeRepo recipeRepo, IRecipeCategoryRepository recipeCategoryRepository)
    {
        _recipeRepo = recipeRepo;
        _recipeCategoryRepository = recipeCategoryRepository;
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesAsync(int pageNumber, int pageSize)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        return await _recipeRepo.GetRecipesAsync(pageNumber, pageSize);
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetRecipesAsync(int pageNumber, int pageSize, string? title, string? searchQuery)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        if (string.IsNullOrEmpty(title) == false && string.IsNullOrEmpty(searchQuery) == false)
        {
            title = title.Trim();
            searchQuery = searchQuery.Trim();
            return await _recipeRepo.GetRecipesAsync(pageNumber, pageSize, title, searchQuery);
        }
        else if (string.IsNullOrEmpty(title) == false)
        {
            title = title.Trim();
            return await _recipeRepo.GetRecipesWithFilterAsync(pageNumber, pageSize, title);
        }
        else if (string.IsNullOrEmpty(searchQuery) == false)
        {
            searchQuery = searchQuery.Trim();
            return await _recipeRepo.GetRecipesWithSearchAsync(pageNumber, pageSize, searchQuery);
        }
        else
        {
            return await GetRecipesAsync(pageNumber, pageSize);
        }
    }

    public async Task<Recipe?> GetRecipeByIdAsync(int id) =>
        await _recipeRepo.GetRecipeByIdAsync(id);


    public async Task<Recipe?> CreateRecipeAsync(RecipeRequest createRecipeRequest)
    {
        Recipe recipe = new()
        {
            Title = createRecipeRequest.Title,
            Description = createRecipeRequest.Description,
            RecipeCategoryId = createRecipeRequest.RecipeCategoryId,
            ModifiedOn = DateTime.UtcNow
        };

        RecipeCategory? category = await _recipeCategoryRepository.Get(createRecipeRequest.RecipeCategoryId);

        if (category is null)
            return null;

        bool isCreated = await _recipeRepo.CreateRecipeAsync(recipe);

        if (isCreated == false)
        {
            return null;
        }

        recipe.RecipeCategory = category;
        return recipe;
    }

    public async Task<bool> UpdateRecipeAsync(int id, RecipeRequest updateRecipeRequest)
    {
        Recipe recipe = new()
        {
            Id = id,
            Title = updateRecipeRequest.Title,
            Description = updateRecipeRequest.Description,
            RecipeCategoryId = updateRecipeRequest.RecipeCategoryId,
            ModifiedOn = DateTime.UtcNow
        };

        return await _recipeRepo.UpdateRecipeAsync(recipe);
    }

    public async Task<bool> DeleteRecipeAsync(int id) =>
        await _recipeRepo.DeleteRecipeAsync(id);


    public async Task<bool> RecipeExistsAsync(int id) =>
        await _recipeRepo.RecipeExistsAsync(id);

}
