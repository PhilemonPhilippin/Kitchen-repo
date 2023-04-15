using Kitchen.Models;

namespace Kitchen.Core.Services;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepo _recipeRepo;
    private readonly IRecipeCategoryRepo _recipeCategoryRepo;
    private const int _maxPageSize = 20;

    public RecipeService(IRecipeRepo recipeRepo, IRecipeCategoryRepo recipeCategoryRepo)
    {
        _recipeRepo = recipeRepo;
        _recipeCategoryRepo = recipeCategoryRepo;
    }

    public async Task<(IEnumerable<Recipe>, PaginationMetadata)> GetRecipesAsync(int pageNumber, int pageSize)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        return await _recipeRepo.GetRecipesAsync(pageNumber, pageSize);
    }

    public async Task<(IEnumerable<Recipe>, PaginationMetadata)> GetRecipesAsync(int pageNumber, int pageSize, string? title, string? searchQuery)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        if (string.IsNullOrEmpty(title) == false && string.IsNullOrEmpty(searchQuery) == false)
        {
            title = title.Trim();
            searchQuery = searchQuery.Trim();
            return await _recipeRepo.GetRecipesWithFilterAndSearchAsync(pageNumber, pageSize, title, searchQuery);
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

    public async Task<Recipe?> GetRecipeByIdAsync(Guid id)
    {
        Recipe? recipe = await _recipeRepo.GetRecipeByIdAsync(id);

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

        RecipeCategory? category = await _recipeCategoryRepo.GetRecipeCategoryByIdAsync(createRecipeRequest.RecipeCategoryId);

        if (category == null)
        {
            return null;
        }

        bool isCreated = await _recipeRepo.CreateRecipeAsync(recipe);

        if (isCreated == false)
        {
            return null;
        }
        else
        {
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
        bool isDeleted = await _recipeRepo.DeleteRecipeAsync(id);
        return isDeleted;
    }

    public async Task<bool> RecipeExistsAsync(Guid id)
    {
        return await _recipeRepo.RecipeExistsAsync(id);
    }
}
