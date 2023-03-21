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
        Recipe recipe = await _context.Recipes.Include(r => r.RecipeCategory).FirstOrDefaultAsync(r => r.Id == id);

        return recipe;
    }

    public async Task<bool> CreateRecipeAsync(Recipe recipe)
    {
        _context.Recipes.Add(recipe);

        int created = await _context.SaveChangesAsync();

        return created > 0;
    }

    public async Task<bool> UpdateRecipeAsync(Guid id, Recipe recipe)
    {
        Recipe recipeToUpdate = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == id);

        if (recipeToUpdate == null)
        {
            return false;
        }

        recipeToUpdate.Title = recipe.Title;
        recipeToUpdate.Description = recipe.Description;
        recipeToUpdate.RecipeCategoryId = recipe.RecipeCategoryId;

        int updated = await _context.SaveChangesAsync();

        return updated > 0;
    }

    public async Task<bool> DeleteRecipeAsync(Guid id)
    {
        Recipe recipe = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == id);

        if (recipe == null)
        {
            return false;
        }

        _context.Recipes.Remove(recipe);
        await _context.SaveChangesAsync();
        return true;
    }
}
