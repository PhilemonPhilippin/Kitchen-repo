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
}
