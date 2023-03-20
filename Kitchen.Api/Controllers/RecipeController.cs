using Kitchen.Api.Contracts.Requests;
using Kitchen.Api.Mappers;
using Kitchen.Entities;
using Microsoft.AspNetCore.Http;
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
            List<Recipe> recipes = await _recipeService.GetRecipesAsync(limit, fromDate);

            if (recipes is null || recipes.Count == 0)
            {
                return NotFound();
            }

            var response = recipes.Select(r => r.MapToRecipeDto()).ToList();

            return Ok(response);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetRecipeById(Guid id)
        {
            Recipe recipe = await _recipeService.GetRecipeByIdAsync(id);

            if (recipe is null)
            {
                return NotFound();
            }


            return Ok(recipe.MapToRecipeDto());
        }
        [HttpPost]
        public async Task<IActionResult> CreateRecipe(CreateRecipeRequest createRecipeRequest)
        {
            Recipe recipe = await _recipeService.CreateRecipe(createRecipeRequest.MapCreateRecipeModel());

            if (recipe is null)
            {
                return BadRequest();
            }

            var response = recipe.MapToRecipeDto();

            return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.Id }, response);

        }
    }
}
