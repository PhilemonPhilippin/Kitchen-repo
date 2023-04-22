using AutoMapper;
using Kitchen.Api.Mappers.Customs;
using Kitchen.Contracts.Requests;
using Kitchen.Core.Interfaces;
using Kitchen.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipes/{recipeId:Guid}/recipeingredients")]
[ApiController]
public class RecipeIngredientsController : ControllerBase
{
    private readonly ILogger<RecipeIngredientsController> _logger;
    private readonly IRecipeIngredientService _recipeIngredientService;
    private readonly IRecipeService _recipeService;
    private readonly IIngredientService _ingredientService;

    public RecipeIngredientsController(
        ILogger<RecipeIngredientsController> logger, IRecipeIngredientService recipeIngredientService, IRecipeService recipeService, IIngredientService ingredientService)
    {
        _logger = logger;
        _recipeIngredientService = recipeIngredientService;
        _recipeService = recipeService;
        _ingredientService = ingredientService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientForSpecificRecipeDto>>> GetRecipeIngredients([FromRoute] Guid recipeId)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when accessing Recipe ingredients");
                return NotFound();
            }
            IEnumerable<RecipeIngredient> recipeIngredients = await _recipeIngredientService.GetRecipeIngredientAsync(recipeId);

            IEnumerable<IngredientForSpecificRecipeDto> ingredients = recipeIngredients.Select(ri => ri.MapForSpecificRecipeDto());

            return Ok(ingredients);
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting recipe ingredients, for recipe id = {recipeId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpPost]
    public async Task<ActionResult> CreateRecipeIngredient(
        [FromRoute] Guid recipeId, [FromBody] CreateRecipeIngredientRequest createRecipeIngredientRequest)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);
            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id = {recipeId} was not found when associating an ingredient with the recipe.");
                return NotFound();
            }

            bool ingredientExists = await _ingredientService.IngredientExistsAsync(createRecipeIngredientRequest.IngredientId);
            if (ingredientExists == false)
            {
                _logger.LogInformation($"Ingredient with id = {createRecipeIngredientRequest.IngredientId} was not found when associating this ingredient with the recipe.");
                return NotFound();
            }

            bool isCreated = await _recipeIngredientService.CreateRecipeIngredientAsync(recipeId, createRecipeIngredientRequest);

            if (isCreated == false)
            {
                _logger.LogInformation($"Could not create the association between recipe with id = {recipeId} and ingredient with id = {createRecipeIngredientRequest.IngredientId}.");
                return BadRequest();
            }

            return NoContent();
        }
        catch (Exception ex) 
        {
            _logger.LogCritical($"While associating an ingredient with a recipe, for recipe id = {recipeId} and ingredient name = {createRecipeIngredientRequest.IngredientId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpPut("{ingredientId:Guid}")]
    public async Task<ActionResult> UpdateRecipeIngredient([FromRoute] Guid recipeId, [FromRoute] Guid ingredientId, [FromBody] UpdateRecipeIngredientRequest updateRecipeIngredientRequest)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when updating association between the ingredient and the recipe.");
                return NotFound();
            }

            bool isUpdated = await _recipeIngredientService.UpdateRecipeIngredientAsync(
                recipeId, ingredientId, updateRecipeIngredientRequest.IngredientQuantity);

            if (isUpdated == false)
            {
                _logger.LogInformation($"Association between recipe with recipeId = {recipeId} and ingredient with ingredientId = {ingredientId} could not be updated.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While updating the association between the recipe id = {recipeId} and ingredient id = {ingredientId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpDelete("{ingredientId:Guid}")]
    public async Task<ActionResult> DeleteRecipeIngredient([FromRoute] Guid recipeId, [FromRoute] Guid ingredientId)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when deleting association between the ingredient and the recipe.");
                return NotFound();
            }

            bool isDeleted = await _recipeIngredientService.DeleteRecipeIngredientAsync(recipeId, ingredientId);

            if (isDeleted == false)
            {
                _logger.LogInformation($"Recipe ingredient with recipe id = {recipeId} and ingredient id = {ingredientId} could not be deleted.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While deleting the association between the recipe with id = {recipeId} and ingredient with id = {ingredientId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
