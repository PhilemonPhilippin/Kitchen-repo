namespace Kitchen.Api.Mappers.Customs;

public static class PreparationStepMapper
{
    public static PreparationStepDto MapToPreparationStepDto(this PreparationStep preparationStep)
    {
        return new PreparationStepDto()
        {
            Id = preparationStep.Id,
            Title = preparationStep.Title,
            StepNumber = preparationStep.StepNumber,
            Step = preparationStep.Step,
            RecipeId = preparationStep.RecipeId,
        };
    }
}
