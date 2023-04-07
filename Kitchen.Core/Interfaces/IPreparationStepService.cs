
namespace Kitchen.Core.Interfaces;

public interface IPreparationStepService
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId);
    Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId);
}
