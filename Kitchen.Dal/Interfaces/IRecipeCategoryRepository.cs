
namespace Kitchen.Dal.Interfaces;

public interface IRecipeCategoryRepository : IRepository<RecipeCategory>
{
    Task<IEnumerable<RecipeCategory>> GetAll();
    Task<bool> IdExist(int id);
}
