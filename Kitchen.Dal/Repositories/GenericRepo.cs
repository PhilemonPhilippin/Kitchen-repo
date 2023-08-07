using Kitchen.Dal.Tools;

namespace Kitchen.Dal.Repositories;

public abstract class GenericRepo<T> : IRepository<T> where T : class
{
    protected readonly KitchenContext context;
    protected readonly ILogger<GenericRepo<T>> logger;

    public GenericRepo(KitchenContext context, ILogger<GenericRepo<T>> logger)
    {
        this.context = context;
        this.logger = logger;
    }

    public virtual async Task<DbResult<T>> Get(int id)
    {
        try
        {
            T? entity = await context.FindAsync<T>(id);

            if (entity is null)
                return new DbResult<T> { Status = Status.NotFound };

            return new DbResult<T> { Entity = entity };
        }
        catch (Exception ex)
        {
            logger.LogCriticalGet(EntityName, id, ex);
            return new DbResult<T> { Status = Status.Error };
        }
    }

    public virtual async Task<DbResult<T>> Add(T entity)
    {
        try
        {
            T? addedEntity = context.Add(entity).Entity;
            await SaveChanges();

            return new DbResult<T> { Entity = addedEntity };
        }
        catch (Exception ex)
        {
            logger.LogCriticalAdd(EntityName, ex);
            return new DbResult<T> { Status = Status.Error };
        }
    }

    public virtual async Task<Status> Delete(int id)
    {
        try
        {
            DbResult<T> dbResult = await Get(id);

            if (dbResult.Status == Status.NotFound)
                return Status.NotFound;

            if (dbResult.Status == Status.Error)
                return Status.Error;

            T entity = dbResult.Entity;

            context.Remove(entity);
            await SaveChanges();
            return Status.Success;
        }
        catch (Exception ex)
        {
            logger.LogCriticalDelete(EntityName, id, ex);
            return Status.Error;
        }
    }

    public async Task<bool> SaveChanges()
    {
        try
        {
            int changes = await context.SaveChangesAsync();
            return changes > 0;
        }
        catch (Exception ex)
        {
            logger.LogCriticalSaveChanges(EntityName, ex);
            return false;
        }
    }
    public abstract Task<Status> Update(T entity);

    public abstract string EntityName { get; }
}