
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

    public async Task<(IEnumerable<Ingredient>, PaginationMetadata)> GetIngredientsAsync(int pageNumber, int pageSize)
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
}
