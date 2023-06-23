using AutoMapper;
using Kitchen.Contracts.Requests;
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

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<RecipeCategoryDto>> GetRecipeCategoryById([FromRoute] Guid id)
    {
        try
        {
            RecipeCategory? recipeCategory = await _recipeCategoryService.GetRecipeCategoryByIdAsync(id);

            if (recipeCategory == null) 
            {
                _logger.LogInformation($"Recipe category with id {id} was not found.");
                return NotFound();
            }

            return Ok(_mapper.Map<RecipeCategoryDto>(recipeCategory));
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting the recipe category with id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPost]
    public async Task<ActionResult<RecipeCategoryDto>> CreateRecipeCategory(
        [FromBody] RecipeCategoryRequest createRecipeCategoryRequest)
    {
        try
        {
            RecipeCategory? recipeCategory = await _recipeCategoryService.CreateRecipeCategoryAsync(createRecipeCategoryRequest);

            if (recipeCategory == null)
            {
                _logger.LogInformation($"Could no create the recipe category with title = {createRecipeCategoryRequest.Title}");
                return BadRequest();
            }

            RecipeCategoryDto response = _mapper.Map<RecipeCategoryDto>(recipeCategory);

            return CreatedAtAction(
                    nameof(GetRecipeCategoryById),
                    new {id = recipeCategory.Id},
                    response
                );
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While creating the recipe category with title = {createRecipeCategoryRequest.Title}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPut("{id:Guid}")]
    public async Task<ActionResult> UpdateRecipeCategory(
        [FromRoute] Guid id, [FromBody] RecipeCategoryRequest updateRecipeCategoryRequest)
    {
        try
        {
            bool isUpdated = await _recipeCategoryService.UpdateRecipeCategoryAsync(id, updateRecipeCategoryRequest);

            if (isUpdated == false)
            {
                _logger.LogInformation($"Recipe category with id {id} could not be updated.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While updating the recipe category with id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult> DeleteRecipeCategory([FromRoute] Guid id)
    {
        try
        {
            bool isDeleted = await _recipeCategoryService.DeleteRecipeCategoryAsync(id);

            if (isDeleted == false)
            {
                _logger.LogInformation($"Recipe category with id {id} could not be deleted.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While deleting the recipe category with id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
