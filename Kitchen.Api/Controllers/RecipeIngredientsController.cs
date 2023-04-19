using AutoMapper;
using Kitchen.Api.Mappers.Customs;
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
    private readonly IMapper _mapper;
    private readonly IRecipeIngredientService _recipeIngredientService;
    private readonly IRecipeService _recipeService;

    public RecipeIngredientsController(
        ILogger<RecipeIngredientsController> logger, IMapper mapper, IRecipeIngredientService recipeIngredientService, IRecipeService recipeService)
    {
        _logger = logger;
        _mapper = mapper;
        _recipeIngredientService = recipeIngredientService;
        _recipeService = recipeService;
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
}
