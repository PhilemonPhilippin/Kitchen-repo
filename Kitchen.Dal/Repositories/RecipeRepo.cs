namespace Kitchen.Dal.Repositories;

public class RecipeRepo : IRecipeRepo
{
    private readonly KitchenContext _context;
    public RecipeRepo(KitchenContext context)
    {
        _context = context;
    }
    public async Task<(IEnumerable<Recipe>, PaginationMetadata)> GetRecipesAsync(int pageNumber, int pageSize)
    {
        IEnumerable<Recipe> recipes = await _context.Recipes
            .Include(r => r.RecipeCategory)
            .OrderBy(r => r.Title)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync();

        int totalItemCount = await _context.Recipes.CountAsync();

        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        return (recipes, metadata);
    }

    public async Task<(IEnumerable<Recipe>, PaginationMetadata)> GetRecipesWithFilterAsync(
        int pageNumber, int pageSize, string title)
    {
        IEnumerable<Recipe> recipes = await _context.Recipes
            .Where(r => r.Title == title)
            .Include(r => r.RecipeCategory)
            .OrderBy(r => r.Title)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync();

        int totalItemCount = await _context.Recipes.Where(r => r.Title == title).CountAsync();

        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        return (recipes, metadata);
    }

    public async Task<(IEnumerable<Recipe>, PaginationMetadata)> GetRecipesWithSearchAsync(
        int pageNumber, int pageSize, string searchQuery)
    {
        IQueryable<Recipe> collection = _context.Recipes;

        collection = collection.Where(r =>
            r.Title.Contains(searchQuery) || (r.Description != null && r.Description.Contains(searchQuery)));

        int totalItemCount = await collection.CountAsync();

        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        IEnumerable<Recipe> recipes = await collection.Include(r => r.RecipeCategory)
        .OrderBy(r => r.Title)
        .Skip(pageSize * (pageNumber - 1))
        .Take(pageSize)
        .ToListAsync();

        return (recipes, metadata);
    }

    public async Task<(IEnumerable<Recipe>, PaginationMetadata)> GetRecipesWithFilterAndSearchAsync(
        int pageNumber, int pageSize, string title, string searchQuery)
    {
        IQueryable<Recipe> collection = _context.Recipes;

        collection = collection.Where(r =>
            (r.Title.Contains(searchQuery) || (r.Description != null && r.Description.Contains(searchQuery)))
            && r.Title == title);

        int totalItemCount = await collection.CountAsync();

        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        IEnumerable<Recipe> recipes = await _context.Recipes.Include(r => r.RecipeCategory)
            .OrderBy(r => r.Title)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync();

        return (recipes, metadata);
    }

    public async Task<Recipe?> GetRecipeByIdAsync(Guid id)
    {
        Recipe? recipe = await _context.Recipes.Include(r => r.RecipeCategory).Where(r => r.Id == id).FirstOrDefaultAsync();

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
        Recipe? recipeToUpdate = await _context.Recipes.Where(r => r.Id == id).FirstOrDefaultAsync();

        if (recipeToUpdate == null)
        {
            return false;
        }

        recipeToUpdate.Title = recipe.Title;
        recipeToUpdate.Description = recipe.Description;
        recipeToUpdate.RecipeCategoryId = recipe.RecipeCategoryId;
        recipeToUpdate.ModifiedOn = DateTime.UtcNow;

        int updated = await _context.SaveChangesAsync();
        return updated > 0;
    }

    public async Task<bool> DeleteRecipeAsync(Guid id)
    {
        Recipe? recipe = await _context.Recipes.Where(r => r.Id == id).FirstOrDefaultAsync();

        if (recipe == null)
        {
            return false;
        }

        _context.Recipes.Remove(recipe);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RecipeExistsAsync(Guid id)
    {
        return await _context.Recipes.AnyAsync(r => r.Id == id);
    }
}
