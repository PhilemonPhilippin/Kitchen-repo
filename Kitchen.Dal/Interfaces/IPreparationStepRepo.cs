namespace Kitchen.Dal.Interfaces;

public interface IPreparationStepRepo
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId);
    Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId);
    Task<bool> CreatePreparationStepAsync(PreparationStep preparationStep);
    Task<bool> UpdatePreparationStepAsync(Guid recipeId, Guid preparationStepId, PreparationStep preparationStep);
}
