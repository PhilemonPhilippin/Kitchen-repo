
namespace Kitchen.Dal.Repositories;

public class IngredientRepository : GenericRepo<Ingredient>, IIngredientRepository
{
    public IngredientRepository(KitchenContext context) : base(context)
    {
    }

    public async Task<bool> IdExist(int id) => await context.Ingredients.AnyAsync(i => i.Id == id);
    public async Task<bool> NameExist(string name) => await context.Ingredients.AnyAsync(i => i.Name.ToLower() == name.ToLower());

    public override async Task<Ingredient?> Add(Ingredient entity)
    {
        bool nameExist = await NameExist(entity.Name);
        if (nameExist)
            return null;

        return await base.Add(entity);
    }

    public override async Task<bool> Update(Ingredient entity)
    {
        var entityToUpdate = await Get(entity.Id);

        if (entityToUpdate is null)
            return false;

        if (await context.Ingredients.AnyAsync(i => i.Name == entity.Name && i.Id != entity.Id))
            return false;

        entityToUpdate.Name = entity.Name;
        entityToUpdate.Description = entity.Description;
        entityToUpdate.ModifiedOn = entity.ModifiedOn;

        return await SaveChanges();
    }

    public async Task<Status> UpdateWithStatus(Ingredient entity)
    {
        var entityToUpdate = await Get(entity.Id);

        if (entityToUpdate is null)
            return Status.NotFound;

        if (await context.Ingredients.AnyAsync(i => i.Name == entity.Name && i.Id != entity.Id))
            return Status.NameConflict;

        entityToUpdate.Name = entity.Name;
        entityToUpdate.Description = entity.Description;
        entityToUpdate.ModifiedOn = entity.ModifiedOn;

        await SaveChanges();

        return Status.Success;
    }

    public async Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize)
    {
        IEnumerable<Ingredient> ingredients = await context.Ingredients
                                                .OrderBy(i => i.Name)
                                                .Skip(pageSize * (pageNumber - 1))
                                                .Take(pageSize)
                                                .ToListAsync();

        int totalItemCount = await context.Ingredients.CountAsync();

        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        return (ingredients, metadata);
    }

    public async Task<IEnumerable<Ingredient>> GetAllNoDescription()
    {
        IEnumerable<Ingredient> ingredients = await context.Ingredients
                                                        .OrderBy(i => i.Name)
                                                        .Select(i => new Ingredient { Id = i.Id, Name = i.Name })
                                                        .ToListAsync();

        return ingredients;
    }
}
