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
                _logger.LogInformationGetAll(nameof(Recipe));
                return NotFound();
            }

            IEnumerable<RecipeDto> response = recipes.Select(r => r.MapToRecipeDto());

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAll(nameof(Recipe), ex);
            return this.InternalErrorCustom();
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
                _logger.LogInformationGet(nameof(Recipe), id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();

            return Ok(dbResult.Entity!.MapToRecipeDto());
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGet(nameof(Recipe), id, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPost]
    public async Task<ActionResult<RecipeDto>> CreateRecipe([FromBody] RecipeRequest createRecipeRequest)
    {
        try
        {
            DbResult<Recipe> dbResult = await _recipeService.Add(createRecipeRequest);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(RecipeCategory), (int)createRecipeRequest.RecipeCategoryId!);
                return NotFound("Recipe category not found.");
            }

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformationCreate(nameof(Recipe), createRecipeRequest.Title);
                return this.InternalErrorCustom();
            }

            RecipeDto response = dbResult.Entity!.MapToRecipeDto();

            return CreatedAtAction(
                nameof(GetRecipeById),
                new { id = dbResult.Entity!.Id },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalCreate(nameof(Recipe), createRecipeRequest.Title, ex);
            return this.InternalErrorCustom();
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
                _logger.LogInformationUpdate(nameof(Recipe), id);
                return NotFound();
            }

            if (updateResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalUpdate(nameof(Recipe), id, ex);
            return this.InternalErrorCustom();
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
                _logger.LogInformationDelete(nameof(Recipe), id);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalDelete(nameof(Recipe), id, ex);
            return this.InternalErrorCustom();
        }
    }
}
