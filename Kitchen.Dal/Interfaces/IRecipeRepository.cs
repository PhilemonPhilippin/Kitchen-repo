
using Kitchen.Entities.Entities;

namespace Kitchen.Dal.Interfaces;

public interface IRecipeRepository : IRepository<Recipe>
{
    Task<bool> IdExist(int id);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPageWithFilter(int pageNumber, int pageSize, string title);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPageWithSearch(int pageNumber, int pageSize, string searchQuery);
    Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize, string title, string searchQuery);
}
