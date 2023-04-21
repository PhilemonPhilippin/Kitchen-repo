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

    public async Task<bool> CreateRecipeIngredientAsync(RecipeIngredient recipeIngredient)
    { 
        _context.RecipeIngredients.Add(recipeIngredient);

        int created = await _context.SaveChangesAsync();

        return created > 0;
    }

    public async Task<bool> RecipeIngredientExistsAsync(RecipeIngredient recipeIngredient)
    {
        return await _context.RecipeIngredients.AnyAsync(
            ri => ri.IngredientId == recipeIngredient.IngredientId && ri.RecipeId == recipeIngredient.RecipeId);
    }

    public async Task<bool> UpdateRecipeIngredientAsync(RecipeIngredient recipeIngredient)
    {
        RecipeIngredient? recipeIngredientToUpdate = await _context.RecipeIngredients
            .Where(ri => ri.IngredientId == recipeIngredient.IngredientId && ri.RecipeId == recipeIngredient.RecipeId)
            .FirstOrDefaultAsync();

        if (recipeIngredientToUpdate == null)
        {
            return false;
        }

        recipeIngredientToUpdate.IngredientQuantity = recipeIngredient.IngredientQuantity;

        int updated = await _context.SaveChangesAsync();

        return updated > 0;

    }
}
