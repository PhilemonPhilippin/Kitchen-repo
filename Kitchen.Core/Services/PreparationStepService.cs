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
    public async Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId) =>
        await _preparationStepRepo.GetPreparationStepsAsync(recipeId);


    public async Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId) =>
        await _preparationStepRepo.GetPreparationStepAsync(recipeId, preparationStepId);


    public async Task<PreparationStep?> CreatePreparationStepAsync(Guid recipeId, PreparationStepRequest createPreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Id = Guid.NewGuid(),
            Title = createPreparationStepRequest.Title,
            Step = createPreparationStepRequest.Step,
            StepNumber = createPreparationStepRequest.StepNumber,
            RecipeId = recipeId,
            CreatedOn = DateTime.UtcNow,
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
        Guid recipeId, Guid preparationStepId, PreparationStepRequest updatePreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Title = updatePreparationStepRequest.Title,
            Step = updatePreparationStepRequest.Step,
            StepNumber = updatePreparationStepRequest.StepNumber,
            ModifiedOn = DateTime.UtcNow
        };

        return await _preparationStepRepo.UpdatePreparationStepAsync(recipeId, preparationStepId, preparationStep);
    }

    public async Task<bool> DeletePreparationStepAsync(Guid recipeId, Guid preparationStepId) =>
        await _preparationStepRepo.DeletePreparationStepAsync(recipeId, preparationStepId);

}
