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
                _logger.LogInformation("Recipe with id {RecipeId} was not found when accessing Recipe ingredients", recipeId);
                return NotFound();
            }
            IEnumerable<RecipeIngredient> recipeIngredients = await _recipeIngredientService.GetAll(recipeId);

            IEnumerable<IngredientForSpecificRecipeDto> ingredients = recipeIngredients.Select(ri => ri.MapForSpecificRecipeDto());
            return Ok(ingredients);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting recipe ingredients, for recipe id = {RecipeId}, error = {Ex}", recipeId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
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
                _logger.LogInformation("Recipe with id = {RecipeId} was not found when associating an ingredient with the recipe.", recipeId);
                return NotFound("Recipe not found.");
            }

            bool ingredientExists = await _ingredientService.IdExist((int)createRecipeIngredientRequest.IngredientId!);
            if (ingredientExists == false)
            {
                _logger.LogInformation("Ingredient with id = {IngredientId} was not found when associating with the recipe with id {RecipeId}.", createRecipeIngredientRequest.IngredientId, recipeId);
                return NotFound("Ingredient not found.");
            }

            bool added = await _recipeIngredientService.Add(recipeId, createRecipeIngredientRequest);

            if (added == false)
            {
                _logger.LogInformation("Could not create the association between recipe with id = {RecipeId} and ingredient with id = {IngredientId}.", recipeId, createRecipeIngredientRequest.IngredientId);
                return StatusCode(500, "A problem occured while handling the request.");
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While associating an ingredient with a recipe, for recipe id = {RecipeId} and ingredient id = {IngredientId}, error = {Ex}", recipeId, createRecipeIngredientRequest.IngredientId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
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
                _logger.LogInformation("Recipe with id {RecipeId} was not found when updating association between the recipe and the ingredient with id {IngredientId}.", recipeId, ingredientId);
                return NotFound();
            }

            Status updateResult = await _recipeIngredientService.Update(
                recipeId, 
                ingredientId, 
                updateRecipeIngredientRequest.IngredientQuantity);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformation("Association between recipe with recipeId = {RecipeId} and ingredient with ingredientId = {IngredientId} could not be updated because it was not found.", recipeId, ingredientId);
                return NotFound();
            }

            if (updateResult == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While updating the association between the recipe id = {RecipeId} and ingredient id = {IngredientId}, error = {Ex}", recipeId, ingredientId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
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
                _logger.LogInformation("Recipe with id {RecipeId} was not found when deleting association between the recipe and the ingredient with id {IngredientId}.", recipeId, ingredientId);
                return NotFound();
            }

            Status deleteResult = await _recipeIngredientService.Delete(recipeId, ingredientId);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformation("Recipe ingredient with recipe id = {RecipeId} and ingredient id = {IngredientId} could not be deleted because it was not found.", recipeId, ingredientId);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While deleting the association between the recipe with id = {RecipeId} and ingredient with id = {IngredientId}, error = {Ex}", recipeId, ingredientId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
