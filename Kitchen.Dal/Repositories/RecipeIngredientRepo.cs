using Microsoft.Extensions.Logging;

namespace Kitchen.Dal.Repositories;

public class RecipeIngredientRepo : IRecipeIngredientRepo
{
    private readonly KitchenContext _context;
    private readonly ILogger<RecipeIngredientRepo> _logger;

    public RecipeIngredientRepo(KitchenContext context, ILogger<RecipeIngredientRepo> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IEnumerable<RecipeIngredient>> GetAll(int recipeId)
    {
        try
        {
            return await _context.RecipeIngredients
                .AsNoTracking()
                .Where(ri => ri.RecipeId == recipeId)
                .Include(ri => ri.Ingredient)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting RecipeIngredients in DB for Recipe id = {RecipeId}, error = {Ex}", recipeId, ex);
            return Enumerable.Empty<RecipeIngredient>();
        }
    }
        


    public async Task<bool> Add(RecipeIngredient recipeIngredient)
    {
        try
        {
            _context.RecipeIngredients.Add(recipeIngredient);

            int created = await _context.SaveChangesAsync();
            return created > 0;
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While adding RecipeIngredient in DB for Recipe id = {RecipeId} and Ingredient id = {IngredientId}, error = {Ex}", recipeIngredient.RecipeId, recipeIngredient.IngredientId, ex);
            return false;
        }
    }

    public async Task<DbResult<bool>> RecipeIngredientExist(RecipeIngredient recipeIngredient)
    {
        try
        {
            bool exists = await _context.RecipeIngredients.AsNoTracking().AnyAsync(ri => ri.IngredientId == recipeIngredient.IngredientId && ri.RecipeId == recipeIngredient.RecipeId);
            return new DbResult<bool> { Entity = exists };
        }
        catch (Exception ex) 
        {
            _logger.LogCritical("While querying if RecipeIngredient exist for Recipe id = {RecipeId} and Ingredient id = {IngredientId}, error = {Ex}", recipeIngredient.RecipeId, recipeIngredient.IngredientId, ex);
            return new DbResult<bool> { Status = Status.Error};
        }
    }

    public async Task<Status> Update(RecipeIngredient recipeIngredient)
    {
        try
        {
            RecipeIngredient? recipeIngredientToUpdate = await GetById(recipeIngredient.RecipeId, recipeIngredient.IngredientId);

            if (recipeIngredientToUpdate is null)
                return Status.NotFound;

            recipeIngredientToUpdate.IngredientQuantity = recipeIngredient.IngredientQuantity;
            recipeIngredientToUpdate.ModifiedOn = recipeIngredient.ModifiedOn;

            int updates = await _context.SaveChangesAsync();
            bool updated = updates > 0;

            if (updated == false)
                return Status.Error;

            return Status.Success;
        } 
        catch (Exception ex)
        {
            _logger.LogCritical("While updating RecipeIngredient in DB for Recipe id = {RecipeId} and Ingredient id = {IngredientId}, error = {Ex}", recipeIngredient.RecipeId, recipeIngredient.IngredientId, ex);
            return Status.Error;
        }

        
    }

    public async Task<Status> Delete(int recipeId, int ingredientId)
    {
        try
        {
            RecipeIngredient? recipeIngredient = await GetById(recipeId, ingredientId);

            if (recipeIngredient is null)
                return Status.NotFound;

            _context.RecipeIngredients.Remove(recipeIngredient);
            await _context.SaveChangesAsync();
            return Status.Success;
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While deleting RecipeIngredient association in DB for Recipe id = {RecipeId} and Ingredient id = {IngredientId}, error = {Ex}", recipeId, ingredientId, ex);
            return Status.Error;
        }
    }

    private async Task<RecipeIngredient?> GetById(int recipeId, int ingredientId)
    {
        try
        {
            return await _context.RecipeIngredients.FirstOrDefaultAsync(ri => ri.IngredientId == ingredientId && ri.RecipeId == recipeId);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While fetching RecipeIngredient for Recipe id = {RecipeId} and Ingredient id = {IngredientId}, error = {Ex}", recipeId, ingredientId, ex);
            return null;
        }
    }
}
