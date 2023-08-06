using Kitchen.Dal.Tools;

namespace Kitchen.Dal.Repositories;

public class RecipeCategoryRepository : GenericRepo<RecipeCategory>, IRecipeCategoryRepository
{
    public override string EntityName { get; } = nameof(RecipeCategory);

    public RecipeCategoryRepository(KitchenContext context, ILogger<RecipeCategoryRepository> logger) : base(context, logger)
    {
    }
    public async Task<IEnumerable<RecipeCategory>> GetAll()
    {
        try
        {
            return await context.RecipeCategories
                .AsNoTracking()
                .OrderBy(rc => rc.Title)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(EntityName, ex);
            return Enumerable.Empty<RecipeCategory>();
        }
    }

    public override async Task<Status> Update(RecipeCategory entity)
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
            entityToUpdate.Description = entity.Description;
            entityToUpdate.ModifiedOn = entity.ModifiedOn;

            await SaveChanges();
            return Status.Success;
        }
        catch (Exception ex)
        {
            logger.LogCriticalUpdate(EntityName, entity.Id, ex);
            return Status.Error;
        }
    }

    public async Task<bool> IdExist(int id)
    {
        try
        {
            return await context.RecipeCategories.AsNoTracking().AnyAsync(i => i.Id == id);
        }
        catch (Exception ex)
        {
            logger.LogCriticalExist(EntityName, id, ex);
            return false;
        }
    }
}
