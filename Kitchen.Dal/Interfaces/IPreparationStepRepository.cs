
namespace Kitchen.Dal.Interfaces;

public interface IPreparationStepRepository : IRepository<PreparationStep>
{
    Task<IEnumerable<PreparationStep>> GetAll(int recipeId);
}
