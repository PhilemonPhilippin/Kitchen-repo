using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IIngredientService
{
    Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Ingredient>> GetIngredientsNoDescAsync();
    Task<Ingredient?> GetIngredientByIdAsync(int id);
    Task<Ingredient?> CreateIngredientAsync(IngredientRequest createIngredientRequest);
    Task<bool> UpdateIngredientAsync(int id, IngredientRequest updateIngredientRequest);
    Task<bool> DeleteIngredientAsync(int id);
    Task<bool> IngredientExistsAsync(int id);
    Task<bool> NameExistAsync(string name);
}
