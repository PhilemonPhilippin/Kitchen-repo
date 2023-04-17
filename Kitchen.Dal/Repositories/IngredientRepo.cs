namespace Kitchen.Dal.Repositories;

public class IngredientRepo : IIngredientRepo
{
    private readonly KitchenContext _context;

    public IngredientRepo(KitchenContext context)
    {
        _context = context;
    }

    public async Task<(IEnumerable<Ingredient>, PaginationMetadata)> GetIngredientsAsync(int pageNumber, int pageSize)
    {
        IEnumerable<Ingredient> ingredients = await _context.Ingredients
            .OrderBy(i => i.Name)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync();

        int totalItemCount = await _context.Ingredients.CountAsync();

        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        return (ingredients, metadata);
    }

    public async Task<Ingredient?> GetIngredientByIdAsync(Guid id)
    {
        Ingredient? ingredient = await _context.Ingredients.Where(i => i.Id == id).FirstOrDefaultAsync();

        return ingredient;
    }

    public async Task<bool> CreateIngredientAsync(Ingredient ingredient)
    {
        _context.Ingredients.Add(ingredient);

        int created = await _context.SaveChangesAsync();

        return created > 0;
    }

    public async Task<bool> UpdateIngredientAsync(Guid id, Ingredient ingredient)
    {
        Ingredient? ingredientToUpdate = await GetIngredientByIdAsync(id);

        if (ingredientToUpdate == null)
        {
            return false;
        }
        

        ingredientToUpdate.Name = ingredient.Name;
        ingredientToUpdate.Description = ingredient.Description;

        int updated = await _context.SaveChangesAsync();
        return updated > 0;
    }
}
