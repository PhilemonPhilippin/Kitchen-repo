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
            (IEnumerable<Recipe> recipes, PaginationMetadata metadata) = await _recipeService.GetPage(pageNumber, pageSize, title, searchQuery);

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
            _logger.LogCritical("While getting the recipes, error = {Ex}", ex);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<RecipeDto>> GetRecipeById([FromRoute] int id)
    {
        try
        {
            DbResult<Recipe> dbResult = await _recipeService.Get(id);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformation("Recipe with id {Id} was not found.", id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return Ok(dbResult.Entity!.MapToRecipeDto());
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting a recipe, for recipe id = {Id}, error = {Ex}", id, ex);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPost]
    public async Task<ActionResult<RecipeDto>> CreateRecipe([FromBody] RecipeRequest createRecipeRequest)
    {
        try
        {
            DbResult<Recipe> dbResult = await _recipeService.Add(createRecipeRequest);

            if (dbResult.Status == Status.NotFound)
                return NotFound("Recipe category not found.");

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformation("Could not create the recipe with title = {Title}", createRecipeRequest.Title);
                return StatusCode(500, "A problem occured while handling the request.");
            }

            RecipeDto response = dbResult.Entity!.MapToRecipeDto();

            return CreatedAtAction(
                nameof(GetRecipeById),
                new { id = dbResult.Entity!.Id },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While creating a recipe, for recipe title = {Title}, error = {Ex}", createRecipeRequest.Title, ex);
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
            Status updateResult = await _recipeService.Update(id, updateRecipeRequest);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformation("Recipe with id {Id} could not be updated.", id);
                return NotFound();
            }

            if (updateResult == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While updating a recipe, for recipe id = {Id}, error = {Ex}", id, ex);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteRecipe([FromRoute] int id)
    {
        try
        {
            Status deleteResult = await _recipeService.Delete(id);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformation("Recipe with id {Id} could not be deleted.", id);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While deleting a recipe, for recipe id = {Id}, error = {Ex}", id, ex);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
