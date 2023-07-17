

using Microsoft.EntityFrameworkCore;

namespace Kitchen.Dal.Repositories;

public class RecipeCategoryRepository : GenericRepo<RecipeCategory>, IRecipeCategoryRepository
{
    public RecipeCategoryRepository(KitchenContext context) : base(context)
    {
    }
    public async Task<IEnumerable<RecipeCategory>> GetAll() =>
                    await context.RecipeCategories.OrderBy(rc => rc.Title).ToListAsync();

    public override async Task<bool> Update(RecipeCategory entity)
    {
        var entityToUpdate = await Get(entity.Id);

        if (entityToUpdate is null)
            return false;

        entityToUpdate.Title = entity.Title;
        entityToUpdate.Description = entity.Description;
        entityToUpdate.ModifiedOn = entity.ModifiedOn;

        return await SaveChanges();
    }
}
