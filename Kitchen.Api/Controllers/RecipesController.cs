using Kitchen.Api.Mappers.Customs;
using Kitchen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Kitchen.Api.Controllers;

[Route("api/recipes")]
[ApiController]
public class RecipesController : ControllerBase
{
    private readonly IRecipeService _recipeService;
    private readonly ILogger<RecipesController> _logger;

    public RecipesController(ILogger<RecipesController> logger, IRecipeService recipeService)
    {
        _logger = logger;
        _recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeDto>>> GetRecipes(
        [FromQuery] int pageNumber,
        [FromQuery] int pageSize,
        [FromQuery] string? title,
        [FromQuery] string? searchQuery)
    {
        try
        {
            (IEnumerable<Recipe> recipes, PaginationMetadata metadata) =
                await _recipeService.GetRecipesAsync(pageNumber, pageSize, title, searchQuery);

            if (recipes is null || recipes.Any() == false)
            {
                _logger.LogInformation("Recipes were not found.");
                return NotFound();
            }

            IEnumerable<RecipeDto> response = recipes.Select(r => r.MapToRecipeDto());

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting the recipes, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<RecipeDto>> GetRecipeById([FromRoute] int id)
    {
        try
        {
            Recipe? recipe = await _recipeService.GetRecipeByIdAsync(id);

            if (recipe is null)
            {
                _logger.LogInformation($"Recipe with id {id} was not found.");
                return NotFound();
            }
            return Ok(recipe.MapToRecipeDto());
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting a recipe, for recipe id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPost]
    public async Task<ActionResult<RecipeDto>> CreateRecipe([FromBody] RecipeRequest createRecipeRequest)
    {
        try
        {
            Recipe? recipe = await _recipeService.CreateRecipeAsync(createRecipeRequest);

            if (recipe is null)
            {
                _logger.LogInformation($"Could not create the recipe with title = {createRecipeRequest.Title}");
                return BadRequest();
            }

            RecipeDto response = recipe.MapToRecipeDto();

            return CreatedAtAction(
                nameof(GetRecipeById),
                new { id = recipe.Id },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While creating a recipe, for recipe title = {createRecipeRequest.Title}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateRecipe(
        [FromRoute] int id,
        [FromBody] RecipeRequest updateRecipeRequest)
    {
        try
        {
            bool isUpdated = await _recipeService.UpdateRecipeAsync(id, updateRecipeRequest);

            if (isUpdated == false)
            {
                _logger.LogInformation($"Recipe with id {id} could not be updated.");
                return NotFound();
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While updating a recipe, for recipe id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteRecipe([FromRoute] int id)
    {
        try
        {
            bool isDeleted = await _recipeService.DeleteRecipeAsync(id);

            if (isDeleted == false)
            {
                _logger.LogInformation($"Recipe with id {id} could not be deleted.");
                return NotFound();
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While deleting a recipe, for recipe id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
