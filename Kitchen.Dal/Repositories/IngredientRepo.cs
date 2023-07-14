namespace Kitchen.Dal.Repositories;

public class IngredientRepo : IIngredientRepo
{
    private readonly KitchenContext _context;

    public IngredientRepo(KitchenContext context)
    {
        _context = context;
    }

    public async Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize)
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

    public async Task<IEnumerable<Ingredient>> GetIngredientsNoDescAsync()
    {
        IEnumerable<Ingredient> ingredients = await _context.Ingredients
            .OrderBy(i => i.Name)
            .Select(i => new Ingredient { Id = i.Id, Name = i.Name})
            .ToListAsync();

        return ingredients;
    }

    public async Task<Ingredient?> GetIngredientByIdAsync(int id) =>
        await _context.Ingredients.FirstOrDefaultAsync(i => i.Id == id);

    public async Task<bool> CreateIngredientAsync(Ingredient ingredient)
    {
        if (await IngredientExistsAsync(ingredient.Name))
            return false;

        _context.Ingredients.Add(ingredient);

        int created = await _context.SaveChangesAsync();

        return created > 0;
    }

    public async Task<bool> UpdateIngredientAsync(Ingredient ingredient)
    {
        Ingredient? ingredientToUpdate = await GetIngredientByIdAsync(ingredient.Id);

        if (ingredientToUpdate is null)
            return false;

        if (await _context.Ingredients.AnyAsync(i => i.Name == ingredient.Name && i.Id != ingredient.Id))
            return false;

        ingredientToUpdate.Name = ingredient.Name;
        ingredientToUpdate.Description = ingredient.Description;
        ingredientToUpdate.ModifiedOn = ingredient.ModifiedOn;

        int updated = await _context.SaveChangesAsync();
        return updated > 0;
    }

    public async Task<bool> DeleteIngredientAsync(int id)
    {
        Ingredient? ingredient = await GetIngredientByIdAsync(id);

        if (ingredient is null)
            return false;


        _context.Ingredients.Remove(ingredient);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> IngredientExistsAsync(int id) =>
        await _context.Ingredients.AnyAsync(i => i.Id == id);

    public async Task<bool> IngredientExistsAsync(string name) =>
        await _context.Ingredients.AnyAsync(i => i.Name.ToLower() == name.ToLower());

}
