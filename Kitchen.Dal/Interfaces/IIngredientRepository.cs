

namespace Kitchen.Dal.Interfaces;

public interface IIngredientRepository : IRepository<Ingredient>
{
    Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize);
    Task<IEnumerable<Ingredient>> GetAllNoDescription();
    Task<bool> IdExist(int id);
    Task<bool> NameExist(string name);
}
