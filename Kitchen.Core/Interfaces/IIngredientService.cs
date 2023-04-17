using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IIngredientService
{
    Task<(IEnumerable<Ingredient>, PaginationMetadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<Ingredient?> GetIngredientByIdAsync(Guid id);
}
