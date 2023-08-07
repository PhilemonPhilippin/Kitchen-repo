
namespace Kitchen.Core.Services;

public class PreparationStepService : IPreparationStepService
{
    private readonly IPreparationStepRepository _preparationStepRepository;

    public PreparationStepService(IPreparationStepRepository preparationStepRepository)
    {
        _preparationStepRepository = preparationStepRepository;
    }
    public async Task<IEnumerable<PreparationStep>> GetAll(int recipeId) => await _preparationStepRepository.GetAll(recipeId);

    public async Task<DbResult<PreparationStep>> Get(int preparationStepId) => await _preparationStepRepository.Get(preparationStepId);

    public async Task<DbResult<PreparationStep>> Add(int recipeId, PreparationStepRequest createPreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Title = createPreparationStepRequest.Title,
            Step = createPreparationStepRequest.Step,
            StepNumber = (int)createPreparationStepRequest.StepNumber,
            RecipeId = recipeId,
            ModifiedOn = DateTime.UtcNow
        };

        DbResult<PreparationStep> preparationStepDbResult = await _preparationStepRepository.Add(preparationStep);
        return preparationStepDbResult;
    }

    public async Task<Status> Update(
        int recipeId, int preparationStepId, PreparationStepRequest updatePreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Id = preparationStepId,
            Title = updatePreparationStepRequest.Title,
            Step = updatePreparationStepRequest.Step,
            StepNumber = (int)updatePreparationStepRequest.StepNumber,
            RecipeId = recipeId,
            ModifiedOn = DateTime.UtcNow
        };

        return await _preparationStepRepository.Update(preparationStep);
    }

    public async Task<Status> Delete(int preparationStepId) => await _preparationStepRepository.Delete(preparationStepId);

}
