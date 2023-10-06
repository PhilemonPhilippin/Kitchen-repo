using Kitchen.Api.Mappers.Customs;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Authorize]
[Route("api/recipes/{recipeId:int}/recipeingredients")]
[ApiController]
public class RecipeIngredientsController : ControllerBase
{
    private readonly ILogger<RecipeIngredientsController> _logger;
    private readonly IRecipeIngredientRepo _recipeIngredientRepo;
    private readonly IRecipeRepository _recipeRepo;
    private readonly IIngredientRepository _ingredientRepo;

    public RecipeIngredientsController(
        ILogger<RecipeIngredientsController> logger,
        IRecipeIngredientRepo recipeIngredientRepo,
        IRecipeRepository recipeRepo,
        IIngredientRepository ingredientRepo)
    {
        _logger = logger;
        _recipeIngredientRepo = recipeIngredientRepo;
        _recipeRepo = recipeRepo;
        _ingredientRepo = ingredientRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientForSpecificRecipeDto>>> GetRecipeIngredients([FromRoute] int recipeId)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }
            IEnumerable<RecipeIngredient> recipeIngredients = await _recipeIngredientRepo.GetAll(recipeId);

            if (recipeIngredients.Any() == false)
            {
                _logger.LogInformationGetAll(nameof(RecipeIngredient));
                return NotFound("Recipe ingredients not found.");
            }

            IEnumerable<IngredientForSpecificRecipeDto> ingredients = recipeIngredients.Select(ri => ri.MapForSpecificRecipeDto());
            return Ok(ingredients);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAllForSpecificRecipe(nameof(RecipeIngredient), recipeId, ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpPost]
    public async Task<ActionResult> CreateRecipeIngredient(
        [FromRoute] int recipeId,
        [FromBody] CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);
            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            bool ingredientExists = await _ingredientRepo.IdExist((int)createRecipeIngredientRequest.IngredientId);
            if (ingredientExists == false)
            {
                _logger.LogInformationGet(nameof(Ingredient), (int)createRecipeIngredientRequest.IngredientId);
                return NotFound("Ingredient not found.");
            }

            RecipeIngredient recipeIngredient = new()
            {
                RecipeId = recipeId,
                IngredientId = (int)createRecipeIngredientRequest.IngredientId,
                IngredientQuantity = createRecipeIngredientRequest.IngredientQuantity,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow
            };

            DbResult<bool> dbResult = await _recipeIngredientRepo.RecipeIngredientExist(recipeIngredient);

            if (dbResult.Status == Status.Error || (dbResult.Status == Status.Success && dbResult.Entity == true))
            {
                _logger.LogInformation("Could not create the association between recipe with id = {RecipeId} and ingredient with id = {IngredientId}.", recipeId, createRecipeIngredientRequest.IngredientId);
                return this.InternalErrorCustom();
            }

            bool added = await _recipeIngredientRepo.Add(recipeIngredient);

            if (added == false)
            {
                _logger.LogInformation("Could not create the association between recipe with id = {RecipeId} and ingredient with id = {IngredientId}.", recipeId, createRecipeIngredientRequest.IngredientId);
                return this.InternalErrorCustom();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While associating an ingredient with a recipe, for recipe id = {RecipeId} and ingredient id = {IngredientId}, error = {Ex}", recipeId, createRecipeIngredientRequest.IngredientId, ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpPut("{ingredientId:int}")]
    public async Task<ActionResult> UpdateRecipeIngredient(
        [FromRoute] int recipeId,
        [FromRoute] int ingredientId,
        [FromBody] UpdateRecipeIngredientRequest updateRecipeIngredientRequest)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found");
            }

            RecipeIngredient recipeIngredient = new()
            {
                IngredientId = ingredientId,
                RecipeId = recipeId,
                IngredientQuantity = updateRecipeIngredientRequest.IngredientQuantity,
                ModifiedOn = DateTime.UtcNow
            };

            Status updateResult = await _recipeIngredientRepo.Update(recipeIngredient);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformation("Association between recipe with recipeId = {RecipeId} and ingredient with ingredientId = {IngredientId} could not be updated because it was not found.", recipeId, ingredientId);
                return NotFound("Recipe ingredient not found.");
            }

            if (updateResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalUpdateForSpecificRecipe(nameof(RecipeIngredient), recipeId, ingredientId, ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpDelete("{ingredientId:int}")]
    public async Task<ActionResult> DeleteRecipeIngredient([FromRoute] int recipeId, [FromRoute] int ingredientId)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            Status deleteResult = await _recipeIngredientRepo.Delete(recipeId, ingredientId);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformation("Recipe ingredient with recipe id = {RecipeId} and ingredient id = {IngredientId} could not be deleted because it was not found.", recipeId, ingredientId);
                return NotFound("Recipe ingredient not found");
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalDeleteForSpecificRecipe(nameof(RecipeIngredient), recipeId, ingredientId, ex);
            return this.InternalErrorCustom();
        }
    }
}
