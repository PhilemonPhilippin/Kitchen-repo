namespace Kitchen.Core.Interfaces;

public interface IPreparationStepService
{
    Task<IEnumerable<PreparationStep>> GetAll(int recipeId);
    Task<DbResult<PreparationStep>> Get(int preparationStepId);
    Task<DbResult<PreparationStep>> Add(int recipeId, PreparationStepRequest createPreparationStepRequest);
    Task<Status> Update(int recipeId, int preparationStepId, PreparationStepRequest updatePreparationStepRequest);
    Task<Status> Delete(int preparationStepId);
}
