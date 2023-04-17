

namespace Kitchen.Dal.Interfaces;

public interface IIngredientRepo
{
    Task<(IEnumerable<Ingredient>, PaginationMetadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<Ingredient?> GetIngredientByIdAsync(Guid id);
    Task<bool> CreateIngredientAsync(Ingredient ingredient);
    Task<bool> UpdateIngredientAsync(Guid id, Ingredient ingredient);

}
