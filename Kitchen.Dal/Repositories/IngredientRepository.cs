using Kitchen.Dal.Tools;

namespace Kitchen.Dal.Repositories;

public class IngredientRepository : GenericRepo<Ingredient>, IIngredientRepository
{
    public override string EntityName { get; } = nameof(Ingredient);
    public IngredientRepository(KitchenContext context, ILogger<IngredientRepository> logger) : base(context, logger)
    {
    }

    public async Task<bool> IdExist(int id)
    {
        try
        {
            return await context.Ingredients.AsNoTracking().AnyAsync(i => i.Id == id);
        }
        catch (Exception ex)
        {
            logger.LogCriticalExist(EntityName, id, ex);
            return false;
        }
    }
    public async Task<bool> NameExist(string name) 
    {
        try
        {
            if (string.IsNullOrEmpty(name))
                return false;

            return await context.Ingredients.AsNoTracking().AnyAsync(i => i.Name.ToLower() == name.ToLower());
        }
        catch (Exception ex)
        {
            logger.LogCritical("While querying if name of Ingredient exist for name = {Name}, error = {Ex}", name, ex);
            return false;
        }
    }

    public override async Task<DbResult<Ingredient>> Add(Ingredient entity)
    {
        try
        {
            bool nameExist = await NameExist(entity.Name);
            if (nameExist)
                return new DbResult<Ingredient> { Status = Status.NameConflict };

            return await base.Add(entity);
        }
        catch (Exception ex)
        {
            logger.LogCriticalAdd(EntityName, ex);
            return new DbResult<Ingredient> { Status = Status.Error };
        }
    }

    public override async Task<Status> Update(Ingredient entity)
    {
        try
        {
            var dbResult = await Get(entity.Id);

            if (dbResult.Status == Status.Error)
                return Status.Error;

            if (dbResult.Status == Status.NotFound)
                return Status.NotFound;

            var entityToUpdate = dbResult.Entity;

            if (await context.Ingredients.AsNoTracking().AnyAsync(i => i.Name == entity.Name && i.Id != entity.Id))
                return Status.NameConflict;

            entityToUpdate.Name = entity.Name;
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

    public async Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize)
    {
        try
        {
            IEnumerable<Ingredient> ingredients = await context.Ingredients
                                                            .AsNoTracking()
                                                            .OrderBy(i => i.Name)
                                                            .Skip(pageSize * (pageNumber - 1))
                                                            .Take(pageSize)
                                                            .ToListAsync();

            int totalItemCount = await context.Ingredients.AsNoTracking().CountAsync();

            PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

            return (ingredients, metadata);
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(EntityName,  ex);
            return (Enumerable.Empty<Ingredient>(), new PaginationMetadata(0, 0, 0));
        }
    }

    public async Task<IEnumerable<Ingredient>> GetAllNoDescription()
    {
        try
        {
            IEnumerable<Ingredient> ingredients = await context.Ingredients
                                                       .AsNoTracking()
                                                       .OrderBy(i => i.Name)
                                                       .Select(i => new Ingredient { Id = i.Id, Name = i.Name })
                                                       .ToListAsync();

            return ingredients;
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(EntityName, ex);
            return Enumerable.Empty<Ingredient>();
        }
    }
}
