namespace Kitchen.Core.Interfaces;

public interface IPreparationStepService
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(int recipeId);
    Task<PreparationStep?> GetPreparationStepAsync(int recipeId, int preparationStepId);
    Task<PreparationStep?> CreatePreparationStepAsync(int recipeId, PreparationStepRequest createPreparationStepRequest);
    Task<bool> UpdatePreparationStepAsync(
        int recipeId, int preparationStepId, PreparationStepRequest updatePreparationStepRequest);
    Task<bool> DeletePreparationStepAsync(int recipeId, int preparationStepId);
}
