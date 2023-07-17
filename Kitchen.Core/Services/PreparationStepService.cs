
namespace Kitchen.Core.Services;

public class PreparationStepService : IPreparationStepService
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IPreparationStepRepository _preparationStepRepository;

    public PreparationStepService(IPreparationStepRepository preparationStepRepository, IRecipeRepository recipeRepository)
    {
        _preparationStepRepository = preparationStepRepository;
        _recipeRepository = recipeRepository;
    }
    public async Task<IEnumerable<PreparationStep>> GetAll(int recipeId) =>
                            await _preparationStepRepository.GetAll(recipeId);

    public async Task<PreparationStep?> Get(int preparationStepId) =>
                            await _preparationStepRepository.Get(preparationStepId);

    public async Task<PreparationStep?> Add(int recipeId, PreparationStepRequest createPreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Title = createPreparationStepRequest.Title,
            Step = createPreparationStepRequest.Step,
            StepNumber = createPreparationStepRequest.StepNumber,
            RecipeId = recipeId,
            ModifiedOn = DateTime.UtcNow
        };

        Recipe? recipe = await _recipeRepository.Get(recipeId);

        if (recipe is null)
            return null;

        PreparationStep? created = await _preparationStepRepository.Add(preparationStep);
        return created;
    }

    public async Task<bool> Update(
        int recipeId, int preparationStepId, PreparationStepRequest updatePreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Id = preparationStepId,
            Title = updatePreparationStepRequest.Title,
            Step = updatePreparationStepRequest.Step,
            StepNumber = updatePreparationStepRequest.StepNumber,
            RecipeId = recipeId,
            ModifiedOn = DateTime.UtcNow
        };

        return await _preparationStepRepository.Update(preparationStep);
    }

    public async Task<bool> Delete(int preparationStepId) =>
                    await _preparationStepRepository.Delete(preparationStepId);

}
