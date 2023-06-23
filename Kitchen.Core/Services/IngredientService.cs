
using Kitchen.Models;

namespace Kitchen.Core.Services;

public class IngredientService : IIngredientService
{
    private readonly IIngredientRepo _ingredientRepo;
    private const int _maxPageSize = 40;
    public IngredientService(IIngredientRepo ingredientRepo)
    {
        _ingredientRepo = ingredientRepo;
    }

    public async Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        return await _ingredientRepo.GetIngredientsAsync(pageNumber, pageSize);
    }

    public async Task<Ingredient?> GetIngredientByIdAsync(Guid id)
    {
        Ingredient? ingredient = await _ingredientRepo.GetIngredientByIdAsync(id);

        return ingredient;
    }

    public async Task<Ingredient?> CreateIngredientAsync(IngredientRequest createIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Id = Guid.NewGuid(),
            Name = createIngredientRequest.Name,
            Description = createIngredientRequest.Description,
            CreatedOn = DateTime.UtcNow,
            ModifiedOn = DateTime.UtcNow
        };

        bool isCreated = await _ingredientRepo.CreateIngredientAsync(ingredient);

        if (isCreated == false)
        {
            return null;
        }

        return ingredient;
    }

    public async Task<bool> UpdateIngredientAsync(Guid id, IngredientRequest updateIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Name = updateIngredientRequest.Name,
            Description= updateIngredientRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        bool isUpdated = await _ingredientRepo.UpdateIngredientAsync(id, ingredient);
        return isUpdated;
    }

    public async Task<bool> DeleteIngredientAsync(Guid id)
    {
        bool isDeleted = await _ingredientRepo.DeleteIngredientAsync(id);
        return isDeleted;
    }

    public async Task<bool> IngredientExistsAsync(Guid id)
    {
        return await _ingredientRepo.IngredientExistsAsync(id);
    }
}
