namespace Kitchen.Dal.Repositories;

public class RecipeIngredientRepo : IRecipeIngredientRepo
{
    private readonly KitchenContext _context;

    public RecipeIngredientRepo(KitchenContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientsAsync(Guid recipeId)
    {
        IEnumerable<RecipeIngredient> recipeIngredients = await _context.RecipeIngredients
            .Where(ri => ri.RecipeId == recipeId)
            .Include(ri => ri.Ingredient)
            .ToListAsync();

        return recipeIngredients;
    }
}
