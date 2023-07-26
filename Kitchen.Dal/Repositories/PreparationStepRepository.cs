namespace Kitchen.Dal.Repositories;

public class PreparationStepRepository : GenericRepo<PreparationStep>, IPreparationStepRepository
{

    public PreparationStepRepository(KitchenContext context) : base(context)
    {
    }

    public override async Task<bool> Update(PreparationStep entity)
    {
        var entityToUpdate = await Get(entity.Id);

        if (entityToUpdate is null)
            return false;

        entityToUpdate.Title = entity.Title;
        entityToUpdate.Step = entity.Step;
        entityToUpdate.StepNumber = entity.StepNumber;
        entityToUpdate.RecipeId = entity.RecipeId;
        entityToUpdate.ModifiedOn = entity.ModifiedOn;

        return await SaveChanges();
    }

    public async Task<IEnumerable<PreparationStep>> GetAll(int recipeId) =>
                                                            await context.PreparationSteps.Where(p => p.RecipeId == recipeId)
                                                                                            .OrderBy(p => p.StepNumber)
                                                                                            .ToListAsync();
                                }
