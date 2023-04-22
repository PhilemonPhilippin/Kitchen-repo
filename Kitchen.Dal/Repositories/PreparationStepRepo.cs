
namespace Kitchen.Dal.Repositories;

public class PreparationStepRepo : IPreparationStepRepo
{
    private readonly KitchenContext _context;

    public PreparationStepRepo(KitchenContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId)
    {
        IEnumerable<PreparationStep> preparationSteps = await _context.PreparationSteps
            .Where(p => p.RecipeId == recipeId)
            .OrderBy(p => p.StepNumber)
            .ToListAsync();

        return preparationSteps;
    }

    public async Task<PreparationStep?> GetPreparationStepAsync(Guid recipeId, Guid preparationStepId)
    {
        PreparationStep? preparationStep = await _context.PreparationSteps
            .Where(p => p.Id == preparationStepId && p.RecipeId == recipeId)
            .FirstOrDefaultAsync();

        return preparationStep;
    }

    public async Task<bool> CreatePreparationStepAsync(PreparationStep preparationStep)
    {
        _context.PreparationSteps.Add(preparationStep);

        int created = await _context.SaveChangesAsync();

        return created > 0;
    }

    public async Task<bool> UpdatePreparationStepAsync(Guid recipeId, Guid preparationStepId, PreparationStep preparationStep)
    {
        PreparationStep? preparationStepToUpdate = await GetPreparationStepAsync(recipeId, preparationStepId);

        if (preparationStepToUpdate == null)
        {
            return false;
        }

        preparationStepToUpdate.Title = preparationStep.Title;
        preparationStepToUpdate.Step = preparationStep.Step;
        preparationStepToUpdate.StepNumber = preparationStep.StepNumber;
        preparationStepToUpdate.RecipeId = recipeId;
        preparationStepToUpdate.ModifiedOn = preparationStep.ModifiedOn;

        int updated = await _context.SaveChangesAsync();

        return updated > 0;
    }

    public async Task<bool> DeletePreparationStepAsync(Guid recipeId, Guid preparationStepId)
    {
        PreparationStep? preparationStep = await GetPreparationStepAsync(recipeId, preparationStepId);

        if (preparationStep == null)
        {
            return false;
        }

        _context.PreparationSteps.Remove(preparationStep);
        await _context.SaveChangesAsync();
        return true;
    }
}
