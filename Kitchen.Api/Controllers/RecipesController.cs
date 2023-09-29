using Kitchen.Api.Mappers.Customs;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Kitchen.Api.Controllers;

[Route("api/recipes")]
[ApiController]
public class RecipesController : ControllerBase
{
    //private readonly IRecipeService _recipeService;
    private readonly IRecipeRepository _recipeRepo;
    private readonly IRecipeCategoryRepository _recipeCategoryRepo;
    private readonly ILogger<RecipesController> _logger;
    private const int _maxPageSize = 20;

    public RecipesController(ILogger<RecipesController> logger, 
        //IRecipeService recipeService, 
        IRecipeRepository recipeRepo,
        IRecipeCategoryRepository recipeCategoryRepo)
    {
        _logger = logger;
        //_recipeService = recipeService;
        _recipeRepo = recipeRepo;
        _recipeCategoryRepo = recipeCategoryRepo;
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
            if (pageSize > _maxPageSize)
                pageSize = _maxPageSize;

            (IEnumerable<Recipe> recipes, PaginationMetadata metadata) result;

            if (string.IsNullOrEmpty(title) == false && string.IsNullOrEmpty(searchQuery) == false)
            {
                title = title.Trim();
                searchQuery = searchQuery.Trim();
                result = await _recipeRepo.GetPage(pageNumber, pageSize, title, searchQuery);
            }
            else if (string.IsNullOrEmpty(title) == false)
            {
                title = title.Trim();
                result = await _recipeRepo.GetPageWithFilter(pageNumber, pageSize, title);
            }
            else if (string.IsNullOrEmpty(searchQuery) == false)
            {
                searchQuery = searchQuery.Trim();
                result = await _recipeRepo.GetPageWithSearch(pageNumber, pageSize, searchQuery);
            }
            else
            {
                result = await _recipeRepo.GetPage(pageNumber, pageSize);
            }
            IEnumerable<Recipe> recipes = result.recipes;
            PaginationMetadata metadata = result.metadata;

            //(IEnumerable<Recipe> recipes, PaginationMetadata metadata) = await _recipeService.GetPage(pageNumber, pageSize, title, searchQuery);

            if (recipes.Any() == false)
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
            DbResult<Recipe> dbResult = await _recipeRepo.Get(id);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(Recipe), id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();

            return Ok(dbResult.Entity.MapToRecipeDto());
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
            Recipe recipe = new()
            {
                Title = createRecipeRequest.Title,
                Description = createRecipeRequest.Description,
                RecipeCategoryId = (int)createRecipeRequest.RecipeCategoryId,
                ModifiedOn = DateTime.UtcNow
            };

            bool categoryExist = await _recipeCategoryRepo.IdExist((int)createRecipeRequest.RecipeCategoryId);
            if (categoryExist == false)
            {
                _logger.LogInformationGet(nameof(RecipeCategory), (int)createRecipeRequest.RecipeCategoryId);
                return NotFound("Recipe category not found.");
            }

            DbResult<Recipe> dbResult = await _recipeRepo.Add(recipe);

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformationCreate(nameof(Recipe), createRecipeRequest.Title);
                return this.InternalErrorCustom();
            }

            RecipeDto response = dbResult.Entity.MapToRecipeDto();

            return CreatedAtAction(
                nameof(GetRecipeById),
                new { id = dbResult.Entity.Id },
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
            Recipe recipe = new()
            {
                Id = id,
                Title = updateRecipeRequest.Title,
                Description = updateRecipeRequest.Description,
                RecipeCategoryId = (int)updateRecipeRequest.RecipeCategoryId,
                ModifiedOn = DateTime.UtcNow
            };

            bool categoryExist = await _recipeCategoryRepo.IdExist((int)updateRecipeRequest.RecipeCategoryId);

            if (categoryExist == false)
            {
                _logger.LogInformationUpdate(nameof(Recipe), id);
                return NotFound();
            }

            Status updateResult = await _recipeRepo.Update(recipe);

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
            Status deleteResult = await _recipeRepo.Delete(id);

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
