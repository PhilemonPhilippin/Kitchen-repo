using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IIngredientService
{
    Task<(IEnumerable<Ingredient>, PaginationMetadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<Ingredient?> GetIngredientByIdAsync(Guid id);
    Task<Ingredient?> CreateIngredientAsync(CreateIngredientRequest createIngredientRequest);
    Task<bool> UpdateIngredientAsync(Guid id, UpdateIngredientRequest updateIngredientRequest);
    Task<bool> DeleteIngredientAsync(Guid id);
}
