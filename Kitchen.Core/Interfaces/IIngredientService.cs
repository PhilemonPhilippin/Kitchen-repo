using Kitchen.Models;

namespace Kitchen.Core.Interfaces;

public interface IIngredientService
{
    Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize);
    Task<IEnumerable<Ingredient>> GetAllNoDescription();
    Task<Ingredient?> Get(int id);
    Task<Ingredient?> Add(IngredientRequest createIngredientRequest);
    Task<bool> Update(int id, IngredientRequest updateIngredientRequest);
    Task<bool> Delete(int id);
    Task<bool> IdExist(int id);
    Task<bool> NameExist(string name);
}
