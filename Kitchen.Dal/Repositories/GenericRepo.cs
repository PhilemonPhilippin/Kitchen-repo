using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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

    public virtual async Task<T?> Update(T entity)
    {
        T? updatedEntity = context.Update(entity).Entity;
        await SaveChanges();

        return updatedEntity;
    }

    public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    {
        var result = await context.Set<T>().AsQueryable().Where(predicate).ToListAsync();

        return result;
    }
    private async Task<bool> SaveChanges()
    {
        int changes = await context.SaveChangesAsync();
        return changes > 0;
    }
}