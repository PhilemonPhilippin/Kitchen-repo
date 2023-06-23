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
        RecipeIngredient? recipeIngredientToUpdate = await GetRecipeIngredientByIdAsync(recipeIngredient.RecipeId, recipeIngredient.IngredientId);

        if (recipeIngredientToUpdate == null)
        {
            return false;
        }

        recipeIngredientToUpdate.IngredientQuantity = recipeIngredient.IngredientQuantity;
        recipeIngredientToUpdate.ModifiedOn = recipeIngredient.ModifiedOn;

        int updated = await _context.SaveChangesAsync();

        return updated > 0;
    }

    public async Task<bool> DeleteRecipeIngredientAsync(Guid recipeId, Guid ingredientId)
    {
        RecipeIngredient? recipeIngredient = await GetRecipeIngredientByIdAsync(recipeId, ingredientId);

        if (recipeIngredient == null)
        {
            return false;
        }

        _context.RecipeIngredients.Remove(recipeIngredient);
        await _context.SaveChangesAsync();
        return true;
    }

    private async Task<RecipeIngredient?> GetRecipeIngredientByIdAsync(Guid recipeId, Guid ingredientId)
    {
        RecipeIngredient? recipeIngredient = await _context.RecipeIngredients
            .FirstOrDefaultAsync(ri => ri.IngredientId == ingredientId && ri.RecipeId == recipeId);

        return recipeIngredient;
    }
}
