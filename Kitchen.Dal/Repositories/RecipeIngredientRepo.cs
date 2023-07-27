namespace Kitchen.Dal.Repositories;

public class RecipeIngredientRepo : IRecipeIngredientRepo
{
    private readonly KitchenContext _context;

    public RecipeIngredientRepo(KitchenContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetRecipeIngredientsAsync(int recipeId) =>
        await _context.RecipeIngredients
        .AsNoTracking()
        .Where(ri => ri.RecipeId == recipeId)
        .Include(ri => ri.Ingredient)
        .ToListAsync();


    public async Task<bool> CreateRecipeIngredientAsync(RecipeIngredient recipeIngredient)
    {
        _context.RecipeIngredients.Add(recipeIngredient);

        int created = await _context.SaveChangesAsync();
        return created > 0;
    }

    public async Task<bool> RecipeIngredientExistsAsync(RecipeIngredient recipeIngredient)
    {
        return await _context.RecipeIngredients.AsNoTracking().AnyAsync(
            ri => ri.IngredientId == recipeIngredient.IngredientId && ri.RecipeId == recipeIngredient.RecipeId);
    }

    public async Task<bool> UpdateRecipeIngredientAsync(RecipeIngredient recipeIngredient)
    {
        RecipeIngredient? recipeIngredientToUpdate = await GetRecipeIngredientByIdAsync(recipeIngredient.RecipeId, recipeIngredient.IngredientId);

        if (recipeIngredientToUpdate is null)
            return false;


        recipeIngredientToUpdate.IngredientQuantity = recipeIngredient.IngredientQuantity;
        recipeIngredientToUpdate.ModifiedOn = recipeIngredient.ModifiedOn;

        int updated = await _context.SaveChangesAsync();
        return updated > 0;
    }

    public async Task<bool> DeleteRecipeIngredientAsync(int recipeId, int ingredientId)
    {
        RecipeIngredient? recipeIngredient = await GetRecipeIngredientByIdAsync(recipeId, ingredientId);

        if (recipeIngredient is null)
            return false;

        _context.RecipeIngredients.Remove(recipeIngredient);
        await _context.SaveChangesAsync();
        return true;
    }

    private async Task<RecipeIngredient?> GetRecipeIngredientByIdAsync(int recipeId, int ingredientId) =>
        await _context.RecipeIngredients
        .FirstOrDefaultAsync(ri => ri.IngredientId == ingredientId && ri.RecipeId == recipeId);

}
