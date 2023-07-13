namespace Kitchen.Dal.Interfaces;

public interface IPreparationStepRepo
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(int recipeId);
    Task<PreparationStep?> GetPreparationStepAsync(int recipeId, int preparationStepId);
    Task<bool> CreatePreparationStepAsync(PreparationStep preparationStep);
    Task<bool> UpdatePreparationStepAsync(int recipeId, PreparationStep preparationStep);
    Task<bool> DeletePreparationStepAsync(int recipeId, int preparationStepId);
}
