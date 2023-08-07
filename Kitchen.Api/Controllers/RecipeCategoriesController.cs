using AutoMapper;
using Kitchen.Models;
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
        ILogger<RecipeCategoriesController> logger,
        IMapper mapper,
        IRecipeCategoryService recipeCategoryService)
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
            IEnumerable<RecipeCategory> recipeCategories = await _recipeCategoryService.GetAll();

            if (recipeCategories.Any() == false)
            {
                _logger.LogInformationGetAll(nameof(RecipeCategory));
                return NotFound();
            }
            IEnumerable<RecipeCategoryDto> response = _mapper.Map<IEnumerable<RecipeCategoryDto>>(recipeCategories);
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAll(nameof(RecipeCategory), ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<RecipeCategoryDto>> GetRecipeCategoryById([FromRoute] int id)
    {
        try
        {
            DbResult<RecipeCategory> dbResult = await _recipeCategoryService.Get(id);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(RecipeCategory), id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();

            return Ok(_mapper.Map<RecipeCategoryDto>(dbResult.Entity));
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGet(nameof(RecipeCategory), id, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPost]
    public async Task<ActionResult<RecipeCategoryDto>> CreateRecipeCategory(
        [FromBody] RecipeCategoryRequest createRecipeCategoryRequest)
    {
        try
        {
            DbResult<RecipeCategory> dbResult = await _recipeCategoryService.Add(createRecipeCategoryRequest);

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformationCreate(nameof(RecipeCategory), createRecipeCategoryRequest.Title);
                return this.InternalErrorCustom();
            }

            RecipeCategoryDto response = _mapper.Map<RecipeCategoryDto>(dbResult.Entity);

            return CreatedAtAction(
                    nameof(GetRecipeCategoryById),
                    new { id = dbResult.Entity.Id },
                    response
                );
        }
        catch (Exception ex)
        {
            _logger.LogCriticalCreate(nameof(RecipeCategory), createRecipeCategoryRequest.Title, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateRecipeCategory(
        [FromRoute] int id,
        [FromBody] RecipeCategoryRequest updateRecipeCategoryRequest)
    {
        try
        {
            Status updateResult = await _recipeCategoryService.Update(id, updateRecipeCategoryRequest);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformationUpdate(nameof(RecipeCategory), id);
                return NotFound();
            }

            if (updateResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalUpdate(nameof(RecipeCategory), id, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteRecipeCategory([FromRoute] int id)
    {
        try
        {
            Status deleteResult = await _recipeCategoryService.Delete(id);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformationDelete(nameof(RecipeCategory), id);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalDelete(nameof(RecipeCategory), id, ex);
            return this.InternalErrorCustom();
        }
    }
}
