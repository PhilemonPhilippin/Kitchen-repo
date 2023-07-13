namespace Kitchen.Dal.Repositories;

public class RecipeCategoryRepo : IRecipeCategoryRepo
{
    private readonly KitchenContext _context;

    public RecipeCategoryRepo(KitchenContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync() =>
        await _context.RecipeCategories.OrderBy(rc => rc.Title).ToListAsync();


    public async Task<RecipeCategory?> GetRecipeCategoryByIdAsync(int id)
        => await _context.RecipeCategories
        .FirstOrDefaultAsync(rc => rc.Id == id);


    public async Task<bool> CreateRecipeCategoryAsync(RecipeCategory recipeCategory)
    {
        _context.RecipeCategories.Add(recipeCategory);

        int created = await _context.SaveChangesAsync();
        return created > 0;
    }

    public async Task<bool> UpdateRecipeCategoryAsync(RecipeCategory recipeCategory)
    {
        RecipeCategory? recipeCategoryToUpdate = await GetRecipeCategoryByIdAsync(recipeCategory.Id);

        if (recipeCategoryToUpdate is null)
            return false;

        recipeCategoryToUpdate.Title = recipeCategory.Title;
        recipeCategoryToUpdate.Description = recipeCategory.Description;
        recipeCategoryToUpdate.ModifiedOn = recipeCategory.ModifiedOn;

        int updated = await _context.SaveChangesAsync();
        return updated > 0;
    }

    public async Task<bool> DeleteRecipeCategoryAsync(int id)
    {
        RecipeCategory? recipeCategory = await GetRecipeCategoryByIdAsync(id);

        if (recipeCategory is null)
        {
            return false;
        }

        _context.RecipeCategories.Remove(recipeCategory);
        await _context.SaveChangesAsync();
        return true;
    }
}
