
namespace Kitchen.Core.Services;

public class PreparationStepService : IPreparationStepService
{
    private readonly IPreparationStepRepo _preparationStepRepo;

    public PreparationStepService(IPreparationStepRepo preparationStepRepo)
    {
        _preparationStepRepo = preparationStepRepo;
    }
    public async Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId)
    {
        return await _preparationStepRepo.GetPreparationStepsAsync(recipeId);
    }

    public async Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId)
    {
        return await _preparationStepRepo.GetPreparationStepAsync(recipeId, preparationStepId);
    }

}
