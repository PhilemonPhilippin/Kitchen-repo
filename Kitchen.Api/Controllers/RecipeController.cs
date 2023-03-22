using Kitchen.Api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet("{limit:int}/{fromDate:DateTime}")]
        public async Task<IActionResult> GetRecipes(int limit, DateTime fromDate)
        {
            try
            {
                List<Recipe> recipes = await _recipeService.GetRecipesAsync(limit, fromDate);

                if (recipes is null || recipes.Count == 0)
                {
                    return NotFound();
                }

                List<RecipeDto> response = recipes.Select(r => r.MapToRecipeDto()).ToList();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetRecipeById(Guid id)
        {
            try
            {
                Recipe recipe = await _recipeService.GetRecipeByIdAsync(id);

                if (recipe is null)
                {
                    return NotFound();
                }


                return Ok(recipe.MapToRecipeDto());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateRecipe(CreateRecipeRequest createRecipeRequest)
        {
            try
            {
                Recipe recipe = await _recipeService.CreateRecipeAsync(createRecipeRequest);

                if (recipe is null)
                {
                    return BadRequest();
                }

                RecipeDto response = recipe.MapToRecipeDto();

                return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.Id }, response);
            }
            catch (Exception ex) 
            {
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
                return StatusCode(500, "A problem occured while handling the request.");
            }
        }
    }
}
