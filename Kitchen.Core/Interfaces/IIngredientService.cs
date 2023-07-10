using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IIngredientService
{
    Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Ingredient>> GetIngredientsNoDescAsync();
    Task<Ingredient?> GetIngredientByIdAsync(Guid id);
    Task<Ingredient?> CreateIngredientAsync(IngredientRequest createIngredientRequest);
    Task<bool> UpdateIngredientAsync(Guid id, IngredientRequest updateIngredientRequest);
    Task<bool> DeleteIngredientAsync(Guid id);
    Task<bool> IngredientExistsAsync(Guid id);
    Task<bool> NameExistAsync(string name);
}
