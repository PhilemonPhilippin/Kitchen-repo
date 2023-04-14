using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipecategories")]
[ApiController]
public class RecipeCategoriesController : ControllerBase
{
    private readonly ILogger<RecipeCategoriesController> _logger;
    private readonly IMapper _mapper;
    private readonly IRecipeCategoryService _recipeCategoryService;

    public RecipeCategoriesController(
        ILogger<RecipeCategoriesController> logger, IMapper mapper, IRecipeCategoryService recipeCategoryService)
    {
        _logger = logger;
        _mapper = mapper;
        _recipeCategoryService = recipeCategoryService;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeCategoryDto>>> GetRecipeCategories()
    {
        try
        {
            IEnumerable<RecipeCategory> recipeCategories = await _recipeCategoryService.GetRecipeCategoriesAsync();

            if (recipeCategories == null || recipeCategories.Count() == 0)
            {
                _logger.LogInformation($"Recipe categories were not found.");
                return NotFound();
            }

            IEnumerable<RecipeCategoryDto> response = _mapper.Map<IEnumerable<RecipeCategoryDto>>(recipeCategories);

            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting the recipe categories, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
