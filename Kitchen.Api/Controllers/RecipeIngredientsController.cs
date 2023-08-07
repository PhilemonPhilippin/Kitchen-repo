using Kitchen.Api.Mappers.Customs;
using Kitchen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipes/{recipeId:int}/recipeingredients")]
[ApiController]
public class RecipeIngredientsController : ControllerBase
{
    private readonly ILogger<RecipeIngredientsController> _logger;
    private readonly IRecipeIngredientService _recipeIngredientService;
    private readonly IRecipeService _recipeService;
    private readonly IIngredientService _ingredientService;

    public RecipeIngredientsController(
        ILogger<RecipeIngredientsController> logger,
        IRecipeIngredientService recipeIngredientService,
        IRecipeService recipeService,
        IIngredientService ingredientService)
    {
        _logger = logger;
        _recipeIngredientService = recipeIngredientService;
        _recipeService = recipeService;
        _ingredientService = ingredientService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientForSpecificRecipeDto>>> GetRecipeIngredients([FromRoute] int recipeId)
    {
        try
        {
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }
            IEnumerable<RecipeIngredient> recipeIngredients = await _recipeIngredientService.GetAll(recipeId);

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
            bool recipeExists = await _recipeService.IdExist(recipeId);
            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            bool ingredientExists = await _ingredientService.IdExist((int)createRecipeIngredientRequest.IngredientId);
            if (ingredientExists == false)
            {
                _logger.LogInformationGet(nameof(Ingredient), (int)createRecipeIngredientRequest.IngredientId);
                return NotFound("Ingredient not found.");
            }

            bool added = await _recipeIngredientService.Add(recipeId, createRecipeIngredientRequest);

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
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found");
            }

            Status updateResult = await _recipeIngredientService.Update(
                recipeId, 
                ingredientId, 
                updateRecipeIngredientRequest.IngredientQuantity);

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
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            Status deleteResult = await _recipeIngredientService.Delete(recipeId, ingredientId);

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
