using Microsoft.EntityFrameworkCore;

namespace Kitchen.Dal.Repositories;

public class RecipeRepository : GenericRepo<Recipe>, IRecipeRepository
{
    public RecipeRepository(KitchenContext context) : base(context)
    {
    }

    public async Task<bool> IdExist(int id) => await context.Recipes.AnyAsync(r => r.Id == id);

    public override async Task<Recipe?> Get(int id) => await context.Recipes.Include(r => r.RecipeCategory).FirstOrDefaultAsync(r => r.Id == id);
    
    public override async Task<bool> Update(Recipe entity)
    {
        var entityToUpdate = await Get(entity.Id);

        if (entityToUpdate is null)
            return false;

        entityToUpdate.Title = entity.Title;
        entityToUpdate.Description = entity.Description;
        entityToUpdate.RecipeCategoryId = entity.RecipeCategoryId;
        entityToUpdate.ModifiedOn = entity.ModifiedOn;

        return await SaveChanges();
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize)
    {
        IEnumerable<Recipe> recipes = await context.Recipes
                                .Include(r => r.RecipeCategory)
                                .OrderBy(r => r.Title)
                                .Skip(pageSize * (pageNumber - 1))
                                .Take(pageSize)
                                .ToListAsync();

        int totalItemCount = await context.Recipes.CountAsync();
        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        return (recipes, metadata);
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPageWithFilter(int pageNumber, int pageSize, string title)
    {
        IEnumerable<Recipe> recipes = await context.Recipes
                        .Where(r => r.Title == title)
                        .Include(r => r.RecipeCategory)
                        .OrderBy(r => r.Title)
                        .Skip(pageSize * (pageNumber - 1))
                        .Take(pageSize)
                        .ToListAsync();

        int totalItemCount = await context.Recipes.Where(r => r.Title == title).CountAsync();
        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        return (recipes, metadata);
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPageWithSearch(int pageNumber, int pageSize, string searchQuery)
    {
        IQueryable<Recipe> collection = context.Recipes;

        collection = collection.Where(r => r.Title.Contains(searchQuery) || (r.Description != null && r.Description.Contains(searchQuery)));

        int totalItemCount = await collection.CountAsync();
        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        IEnumerable<Recipe> recipes = await collection.Include(r => r.RecipeCategory)
                        .OrderBy(r => r.Title)
                        .Skip(pageSize * (pageNumber - 1))
                        .Take(pageSize)
                        .ToListAsync();

        return (recipes, metadata);
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize, string title, string searchQuery)
    {
        IQueryable<Recipe> collection = context.Recipes;

        collection = collection
            .Where(r => (r.Title.Contains(searchQuery) || (r.Description != null && r.Description.Contains(searchQuery)))
            && r.Title == title);

        int totalItemCount = await collection.CountAsync();
        PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

        IEnumerable<Recipe> recipes = await context.Recipes.Include(r => r.RecipeCategory)
                        .OrderBy(r => r.Title)
                        .Skip(pageSize * (pageNumber - 1))
                        .Take(pageSize)
                        .ToListAsync();

        return (recipes, metadata);
    }
}
