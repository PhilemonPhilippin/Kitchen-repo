using Microsoft.Extensions.Logging;

namespace Kitchen.Dal.Repositories;

public class PreparationStepRepository : GenericRepo<PreparationStep>, IPreparationStepRepository
{

    public PreparationStepRepository(KitchenContext context, ILogger<PreparationStepRepository> logger) : base(context, logger)
    {
    }

    public override async Task<Status> Update(PreparationStep entity)
    {
        try
        {
            var dbResult = await Get(entity.Id);

            if (dbResult.Status == Status.Error)
                return Status.Error;

            if (dbResult.Status == Status.NotFound)
                return Status.NotFound;

            var entityToUpdate = dbResult.Entity!;

            entityToUpdate.Title = entity.Title;
            entityToUpdate.Step = entity.Step;
            entityToUpdate.StepNumber = entity.StepNumber;
            entityToUpdate.RecipeId = entity.RecipeId;
            entityToUpdate.ModifiedOn = entity.ModifiedOn;

            await SaveChanges();
            return Status.Success;
        }
        catch (Exception ex)
        {
            logger.LogCritical("While updating preparation step in DB for id = {Id}, error = {Ex}", entity.Id, ex.Message);
            return Status.Error;
        }
    }

    public async Task<IEnumerable<PreparationStep>> GetAll(int recipeId)
    {
        try
        {
            return await context.PreparationSteps
                .AsNoTracking()
                .Where(p => p.RecipeId == recipeId)
                .OrderBy(p => p.StepNumber)
                .ToListAsync();
        }
        catch(Exception ex)
        {
            logger.LogCritical("While getting preparation steps in DB, error = {Ex}", ex.Message);
            return Enumerable.Empty<PreparationStep>();
        }
    }
}
