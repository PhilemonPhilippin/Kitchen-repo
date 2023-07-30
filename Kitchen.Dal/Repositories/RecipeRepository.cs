using Kitchen.Dal.Tools;

namespace Kitchen.Dal.Repositories;

public class RecipeRepository : GenericRepo<Recipe>, IRecipeRepository
{
    private readonly IRecipeCategoryRepository _recipeCategoryRepository;

    public RecipeRepository(KitchenContext context, ILogger<RecipeRepository> logger, IRecipeCategoryRepository recipeCategoryRepository) : base(context, logger)
    {
        _recipeCategoryRepository = recipeCategoryRepository;
    }

    public async Task<bool> IdExist(int id)
    {
        try
        {
            return await context.Recipes.AsNoTracking().AnyAsync(r => r.Id == id);
        }
        catch (Exception ex)
        {
            logger.LogCriticalExist(nameof(Recipe), id, ex);
            return false;
        }
    }

    public override async Task<DbResult<Recipe>> Get(int id)
    {
        try
        {
            Recipe? recipe = await context.Recipes.Include(r => r.RecipeCategory).FirstOrDefaultAsync(r => r.Id == id);

            if (recipe is null)
                return new DbResult<Recipe> { Status = Status.NotFound };

            return new DbResult<Recipe> { Entity = recipe };
        }
        catch (Exception ex)
        {
            logger.LogCriticalGet(nameof(Recipe), id, ex);
            return new DbResult<Recipe> { Status = Status.Error };
        }
    }

    public override async Task<DbResult<Recipe>> Add(Recipe entity)
    {
        try
        {
            var addedEntity = context.Recipes.Add(entity).Entity;
            await SaveChanges();


            DbResult<RecipeCategory> dbResult = await _recipeCategoryRepository.Get(entity.RecipeCategoryId);

            if (dbResult.Status == Status.NotFound)
                return new DbResult<Recipe> { Status = Status.NotFound };

            if (dbResult.Status == Status.Error)
                return new DbResult<Recipe> { Status = Status.Error };

            addedEntity.RecipeCategory = dbResult.Entity!;

            return new DbResult<Recipe> { Entity = addedEntity };
        }
        catch (Exception ex)
        {
            logger.LogCriticalAdd(nameof(Recipe), ex);
            return new DbResult<Recipe> { Status = Status.Error };
        }
    }

    public override async Task<Status> Update(Recipe entity)
    {
        try
        {
            var dbResult = await Get(entity.Id);

            if (dbResult.Status == Status.Error)
                return Status.Error;

            if (dbResult.Status == Status.NotFound)
                return Status.NotFound;

            var entityToUpdate = dbResult.Entity!;

            entityToUpdate.Title = entity.Title;
            entityToUpdate.Description = entity.Description;
            entityToUpdate.RecipeCategoryId = entity.RecipeCategoryId;
            entityToUpdate.ModifiedOn = entity.ModifiedOn;

            await SaveChanges();
            return Status.Success;
        }
        catch (Exception ex)
        {
            logger.LogCriticalUpdate(nameof(Recipe), entity.Id, ex);
            return Status.Error;
        }
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize)
    {
        try
        {
            IEnumerable<Recipe> recipes =
            await context.Recipes
            .AsNoTracking()
            .Include(r => r.RecipeCategory)
            .OrderBy(r => r.Title)
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync();

            int totalItemCount = await context.Recipes.AsNoTracking().CountAsync();
            PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

            return (recipes, metadata);
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(nameof(Recipe), ex);
            return (Enumerable.Empty<Recipe>(), new PaginationMetadata(0, 0, 0));
        }
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPageWithFilter(int pageNumber, int pageSize, string title)
    {
        try
        {
            IEnumerable<Recipe> recipes =
                await context.Recipes
                .AsNoTracking()
                .Where(r => r.Title == title)
                .Include(r => r.RecipeCategory)
                .OrderBy(r => r.Title)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            int totalItemCount = await context.Recipes.AsNoTracking().Where(r => r.Title == title).CountAsync();
            PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

            return (recipes, metadata);
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(nameof(Recipe), ex);
            return (Enumerable.Empty<Recipe>(), new PaginationMetadata(0, 0, 0));
        }
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPageWithSearch(int pageNumber, int pageSize, string searchQuery)
    {
        try
        {
            IQueryable<Recipe> collection = context.Recipes;

            collection = collection.AsNoTracking().Where(r => r.Title.Contains(searchQuery) || (r.Description != null && r.Description.Contains(searchQuery)));

            int totalItemCount = await collection.CountAsync();
            PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

            IEnumerable<Recipe> recipes =
                await collection
                .Include(r => r.RecipeCategory)
                .OrderBy(r => r.Title)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            return (recipes, metadata);
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(nameof(Recipe), ex);
            return (Enumerable.Empty<Recipe>(), new PaginationMetadata(0, 0, 0));
        }
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize, string title, string searchQuery)
    {
        try
        {
            IQueryable<Recipe> collection = context.Recipes.AsNoTracking();

            collection = collection
                .Where(r =>
                (r.Title.Contains(searchQuery) || (r.Description != null && r.Description.Contains(searchQuery)))
                && r.Title == title);

            int totalItemCount = await collection.CountAsync();
            PaginationMetadata metadata = new(pageNumber, pageSize, totalItemCount);

            IEnumerable<Recipe> recipes =
                await collection
                .Include(r => r.RecipeCategory)
                .OrderBy(r => r.Title)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            return (recipes, metadata);
        }
        catch (Exception ex)
        {
            logger.LogCriticalGetAll(nameof(Recipe), ex);
            return (Enumerable.Empty<Recipe>(), new PaginationMetadata(0, 0, 0));
        }
    }

    public override string EntityName { get; } = nameof(Recipe);
}
