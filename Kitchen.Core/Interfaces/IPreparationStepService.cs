
namespace Kitchen.Core.Interfaces;

public interface IPreparationStepService
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId);
    Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId);
    Task<PreparationStep?> CreatePreparationStepAsync(Guid recipeId, CreatePreparationStepRequest createPreparationStepRequest);
    Task<bool> UpdatePreparationStepAsync(
        Guid recipeId, Guid preparationStepId, UpdatePreparationStepRequest updatePreparationStepRequest);
    Task<bool> DeletePreparationStepAsync(Guid recipeId, Guid preparationStepId);
}
