

namespace Kitchen.Dal.Interfaces;

public interface IIngredientRepo
{
    Task<(IEnumerable<Ingredient>, PaginationMetadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<Ingredient?> GetIngredientByIdAsync(Guid id);
}
