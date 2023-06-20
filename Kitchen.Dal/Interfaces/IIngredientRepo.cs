

namespace Kitchen.Dal.Interfaces;

public interface IIngredientRepo
{
    Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<Ingredient?> GetIngredientByIdAsync(Guid id);
    Task<bool> CreateIngredientAsync(Ingredient ingredient);
    Task<bool> UpdateIngredientAsync(Guid id, Ingredient ingredient);
    Task<bool> DeleteIngredientAsync(Guid id);
    Task<bool> IngredientExistsAsync(Guid id);
}
