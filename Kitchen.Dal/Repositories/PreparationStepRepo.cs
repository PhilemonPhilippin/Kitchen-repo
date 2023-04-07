
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
}
