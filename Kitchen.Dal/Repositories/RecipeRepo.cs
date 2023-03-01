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
        List<Recipe> recipes = await _context.Recipes.Where(r => r.CreatedOn >= fromDate).Include(r => r.RecipeCategory).OrderBy(r => r.CreatedOn).Take(limit).ToListAsync();

        return recipes;
    }

    public async Task<Recipe> GetRecipeByIdAsync(Guid id)
    {
        Recipe recipe = await _context.Recipes.Include(r => r.RecipeCategory).SingleOrDefaultAsync(r => r.Id == id);

        return recipe;
    }
}
