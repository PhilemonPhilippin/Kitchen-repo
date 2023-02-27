using Kitchen.Api.Contracts;
using Kitchen.Api.Contracts.Responses;
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
            ApiResponse<List<RecipeResponse>> response = new();

            if (recipes is null || recipes.Count == 0)
            {
                response.Success = false;
                response.Message = "Could not find any recipe.";

                return NotFound(response);
            }
            
            response.Data = recipes.Select(r => r.MapRecipeResponse()).ToList();

            return Ok(response);
        }
    }
}
