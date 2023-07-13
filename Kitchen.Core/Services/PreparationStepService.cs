namespace Kitchen.Core.Services;

public class PreparationStepService : IPreparationStepService
{
    private readonly IPreparationStepRepo _preparationStepRepo;
    private readonly IRecipeRepo _recipeRepo;

    public PreparationStepService(IPreparationStepRepo preparationStepRepo, IRecipeRepo recipeRepo)
    {
        _preparationStepRepo = preparationStepRepo;
        _recipeRepo = recipeRepo;
    }
    public async Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(int recipeId) =>
        await _preparationStepRepo.GetPreparationStepsAsync(recipeId);


    public async Task<PreparationStep?> GetPreparationStepAsync(int recipeId, int preparationStepId) =>
        await _preparationStepRepo.GetPreparationStepAsync(recipeId, preparationStepId);


    public async Task<PreparationStep?> CreatePreparationStepAsync(int recipeId, PreparationStepRequest createPreparationStepRequest)
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


        bool isCreated = await _preparationStepRepo.CreatePreparationStepAsync(preparationStep);

        if (isCreated == false)
            return null;

        preparationStep.Recipe = recipe;
        return preparationStep;
    }

    public async Task<bool> UpdatePreparationStepAsync(
        int recipeId, int preparationStepId, PreparationStepRequest updatePreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Id = preparationStepId,
            Title = updatePreparationStepRequest.Title,
            Step = updatePreparationStepRequest.Step,
            StepNumber = updatePreparationStepRequest.StepNumber,
            ModifiedOn = DateTime.UtcNow
        };

        return await _preparationStepRepo.UpdatePreparationStepAsync(recipeId, preparationStep);
    }

    public async Task<bool> DeletePreparationStepAsync(int recipeId, int preparationStepId) =>
        await _preparationStepRepo.DeletePreparationStepAsync(recipeId, preparationStepId);

}
