
namespace Kitchen.Dal.Repositories;

public class PreparationStepRepo : IPreparationStepRepo
{
    private readonly KitchenContext _context;

    public PreparationStepRepo(KitchenContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(int recipeId) =>
        await _context.PreparationSteps
        .Where(p => p.RecipeId == recipeId)
        .OrderBy(p => p.StepNumber)
        .ToListAsync();

    public async Task<PreparationStep?> GetPreparationStepAsync(int recipeId, int preparationStepId) =>
        await _context.PreparationSteps
        .FirstOrDefaultAsync(p => p.Id == preparationStepId && p.RecipeId == recipeId);

    public async Task<bool> CreatePreparationStepAsync(PreparationStep preparationStep)
    {
        _context.PreparationSteps.Add(preparationStep);

        int created = await _context.SaveChangesAsync();
        return created > 0;
    }

    public async Task<bool> UpdatePreparationStepAsync(int recipeId, PreparationStep preparationStep)
    {
        PreparationStep? preparationStepToUpdate = await GetPreparationStepAsync(recipeId, preparationStep.Id);

        if (preparationStepToUpdate is null)
            return false;


        preparationStepToUpdate.Title = preparationStep.Title;
        preparationStepToUpdate.Step = preparationStep.Step;
        preparationStepToUpdate.StepNumber = preparationStep.StepNumber;
        preparationStepToUpdate.RecipeId = recipeId;
        preparationStepToUpdate.ModifiedOn = preparationStep.ModifiedOn;

        int updated = await _context.SaveChangesAsync();
        return updated > 0;
    }

    public async Task<bool> DeletePreparationStepAsync(int recipeId, int preparationStepId)
    {
        PreparationStep? preparationStep = await GetPreparationStepAsync(recipeId, preparationStepId);

        if (preparationStep is null)
            return false;

        _context.PreparationSteps.Remove(preparationStep);
        await _context.SaveChangesAsync();
        return true;
    }
}
