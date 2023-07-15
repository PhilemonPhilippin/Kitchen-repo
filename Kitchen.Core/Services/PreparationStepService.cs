
namespace Kitchen.Core.Services;

public class PreparationStepService : IPreparationStepService
{
    private readonly IRecipeRepo _recipeRepo;
    private readonly IPreparationStepRepository _preparationStepRepository;

    public PreparationStepService(IPreparationStepRepository preparationStepRepository, IRecipeRepo recipeRepo)
    {
        _preparationStepRepository = preparationStepRepository;
        _recipeRepo = recipeRepo;
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

        Recipe? recipe = await _recipeRepo.GetRecipeByIdAsync(recipeId);

        if (recipe is null)
            return null;

        PreparationStep? created = await _preparationStepRepository.Add(preparationStep);

        return created;
    }

    public async Task<PreparationStep?> Update(
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

        PreparationStep? updated = await _preparationStepRepository.Update(preparationStep);

        return updated;
    }

    public async Task<bool> Delete(int preparationStepId) =>
                    await _preparationStepRepository.Delete(preparationStepId);

}
