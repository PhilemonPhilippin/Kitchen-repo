﻿
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
    public async Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId)
    {
        return await _preparationStepRepo.GetPreparationStepsAsync(recipeId);
    }

    public async Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId)
    {
        return await _preparationStepRepo.GetPreparationStepAsync(recipeId, preparationStepId);
    }

    public async Task<PreparationStep?> CreatePreparationStepAsync(Guid recipeId, CreatePreparationStepRequest createPreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Id = Guid.NewGuid(),
            Title = createPreparationStepRequest.Title,
            Step = createPreparationStepRequest.Step,
            StepNumber = createPreparationStepRequest.StepNumber,
            RecipeId = recipeId
        };

        Recipe? recipe = await _recipeRepo.GetRecipeByIdAsync(recipeId);

        if (recipe == null)
        {
            return null;
        }

        bool isCreated = await _preparationStepRepo.CreatePreparationStepAsync(preparationStep);

        if (isCreated == false)
        {
            return null;
        }
        else
        {
            preparationStep.Recipe = recipe;
            return preparationStep;
        }
    }

    public async Task<bool> UpdatePreparationStepAsync(
        Guid recipeId, Guid preparationStepId, UpdatePreparationStepRequest updatePreparationStepRequest)
    {
        PreparationStep preparationStep = new()
        {
            Title = updatePreparationStepRequest.Title,
            Step = updatePreparationStepRequest.Step,
            StepNumber= updatePreparationStepRequest.StepNumber
        };

        bool isUpdated = await _preparationStepRepo.UpdatePreparationStepAsync(recipeId, preparationStepId, preparationStep);
        return isUpdated;
    }

    public async Task<bool> DeletePreparationStepAsync(Guid recipeId, Guid preparationStepId)
    {
        return await _preparationStepRepo.DeletePreparationStepAsync(recipeId, preparationStepId);
    }
}