
namespace Kitchen.Core.Interfaces;

public interface IPreparationStepService
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId);
}
