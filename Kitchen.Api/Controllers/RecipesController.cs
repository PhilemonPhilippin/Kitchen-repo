using Kitchen.Api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        private readonly ILogger<RecipesController> _logger;

        public RecipesController(ILogger<RecipesController> logger, IRecipeService recipeService)
        {
            _recipeService = recipeService;
            _logger = logger;
        }

        [HttpGet("{limit:int}/{fromDate:DateTime}")]
        public async Task<IActionResult> GetRecipes(int limit, DateTime fromDate)
        {
            try
            {
                IEnumerable<Recipe> recipes = await _recipeService.GetRecipesAsync(limit, fromDate);

                if (recipes is null || recipes.Count() == 0)
                {
                    return NotFound();
                }

                IEnumerable<RecipeDto> response = recipes.Select(r => r.MapToRecipeDto());

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetRecipeById(Guid id)
        {
            try
            {
                Recipe? recipe = await _recipeService.GetRecipeByIdAsync(id);

                if (recipe is null)
                {
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
        public async Task<IActionResult> CreateRecipe(CreateRecipeRequest createRecipeRequest)
        {
            try
            {
                Recipe? recipe = await _recipeService.CreateRecipeAsync(createRecipeRequest);

                if (recipe is null)
                {
                    return BadRequest();
                }

                RecipeDto response = recipe.MapToRecipeDto();

                return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.Id }, response);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"While creating a recipe, for recipe title = {createRecipeRequest.Title}, error = {ex}");
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateRecipe(Guid id, UpdateRecipeRequest updateRecipeRequest)
        {
            try
            {
                bool isUpdated = await _recipeService.UpdateRecipeAsync(id, updateRecipeRequest);

                return isUpdated ? NoContent() : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"While updating a recipe, for recipe id = {id}, error = {ex}");
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteRecipe(Guid id)
        {
            try
            {
                bool isDeleted = await _recipeService.DeleteRecipeAsync(id);

                return isDeleted ? NoContent() : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"While deleting a recipe, for recipe id = {id}, error = {ex}");
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }
    }
}
