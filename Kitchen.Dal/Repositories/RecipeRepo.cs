namespace Kitchen.Dal.Repositories;

public class RecipeRepo : IRecipeRepo
{
    private readonly KitchenContext _context;
    public RecipeRepo(KitchenContext context)
    {
        _context = context;
    }
    public async Task<List<Recipe>> GetRecipesAsync(int limit, DateTime fromDate)
    {
        List<Recipe> recipes = await _context.Recipes.Where(r => r.CreatedOn >= fromDate).OrderBy(r => r.CreatedOn).Take(limit).ToListAsync();

        return recipes;
    }
}
