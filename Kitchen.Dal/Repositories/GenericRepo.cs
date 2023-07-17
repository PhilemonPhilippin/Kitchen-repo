
namespace Kitchen.Dal.Repositories;

public abstract class GenericRepo<T> : IRepository<T> where T : class
{
    protected KitchenContext context;
    public GenericRepo(KitchenContext context)
    {
        this.context = context;
    }

    public virtual async Task<T?> Get(int id)
    {
        T? entity = await context.FindAsync<T>(id);

        return entity;
    }

    public virtual async Task<T?> Add(T entity)
    {
        T? addedEntity = context.Add(entity).Entity;
        await SaveChanges();

        return addedEntity;
    }

    public virtual async Task<bool> Delete(int id)
    {
        T? entityToDelete = await Get(id);

        if (entityToDelete is not null)
            context.Remove(entityToDelete);

        return await SaveChanges();
    }

    public virtual async Task<bool> Update(T entity)
    {
        context.Update(entity);
        return await SaveChanges();
    }

    public async Task<bool> SaveChanges()
    {
        int changes = await context.SaveChangesAsync();
        return changes > 0;
    }
}