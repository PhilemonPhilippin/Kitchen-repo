using AutoMapper;
using Kitchen.Api.Mappers;
using Kitchen.Entities;
using Kitchen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Kitchen.Api.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;
        private readonly ILogger<RecipesController> _logger;

        public RecipesController(ILogger<RecipesController> logger, IMapper mapper, IRecipeService recipeService)
        {
            _mapper = mapper;
            _logger = logger;
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetRecipes(
            [FromQuery] int pageNumber, [FromQuery] int pageSize, [FromQuery] string? title, [FromQuery] string? searchQuery)
        {
            try
            {
                var recipesTuple = await _recipeService.GetRecipesAsync(pageNumber, pageSize, title, searchQuery);

                IEnumerable<Recipe> recipes = recipesTuple.Item1;
                PaginationMetadata metadata = recipesTuple.Item2;

                if (recipes == null || recipes.Count() == 0)
                {
                    _logger.LogInformation($"Recipes were not found.");
                    return NotFound();
                }

                IEnumerable<RecipeDto> response = _mapper.Map<IEnumerable<RecipeDto>>(recipes);

                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"While getting the recipes, error = {ex}");
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<RecipeDto>> GetRecipeById([FromRoute] Guid id)
        {
            try
            {
                Recipe? recipe = await _recipeService.GetRecipeByIdAsync(id);

                if (recipe == null)
                {
                    _logger.LogInformation($"Recipe with id {id} was not found.");
                    return NotFound();
                }

                return Ok(_mapper.Map<RecipeDto>(recipe));
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"While getting a recipe, for recipe id = {id}, error = {ex}");
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }
        [HttpPost]
        public async Task<ActionResult<RecipeDto>> CreateRecipe([FromBody] CreateRecipeRequest createRecipeRequest)
        {
            try
            {
                Recipe? recipe = await _recipeService.CreateRecipeAsync(createRecipeRequest);

                if (recipe == null)
                {
                    _logger.LogInformation($"Could no create the recipe with title = {createRecipeRequest.Title}");
                    return BadRequest();
                }

                RecipeDto response = _mapper.Map<RecipeDto>(recipe);

                return CreatedAtAction(
                    nameof(GetRecipeById),
                    new 
                    { id = recipe.Id }, 
                    response);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"While creating a recipe, for recipe title = {createRecipeRequest.Title}, error = {ex}");
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult> UpdateRecipe(
            [FromRoute] Guid id, [FromBody] UpdateRecipeRequest updateRecipeRequest)
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

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteRecipe([FromRoute] Guid id)
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
}
