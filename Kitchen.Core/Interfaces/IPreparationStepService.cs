namespace Kitchen.Core.Interfaces;

public interface IPreparationStepService
{
    Task<IEnumerable<PreparationStep>> GetAll(int recipeId);
    Task<PreparationStep?> Get(int preparationStepId);
    Task<PreparationStep?> Add(int recipeId, PreparationStepRequest createPreparationStepRequest);
    Task<PreparationStep?> Update(
        int recipeId, int preparationStepId, PreparationStepRequest updatePreparationStepRequest);
    Task<bool> Delete(int preparationStepId);
}
