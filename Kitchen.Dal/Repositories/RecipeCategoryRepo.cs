namespace Kitchen.Dal.Repositories;

public class RecipeCategoryRepo : IRecipeCategoryRepo
{
    private readonly KitchenContext _context;

    public RecipeCategoryRepo(KitchenContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RecipeCategory>> GetRecipeCategoriesAsync()
    {
        IEnumerable<RecipeCategory> recipeCategories = await _context.RecipeCategories.OrderBy(rc => rc.Title).ToListAsync();

        return recipeCategories;
    }

    public async Task<RecipeCategory?> GetRecipeCategoryByIdAsync(Guid id)
    {
        RecipeCategory? recipeCategory = await _context.RecipeCategories.Where(rc => rc.Id == id).FirstOrDefaultAsync();

        return recipeCategory;
    }
}
