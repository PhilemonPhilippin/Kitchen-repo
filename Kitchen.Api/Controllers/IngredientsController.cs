using Kitchen.Api.Mappers.Customs;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Kitchen.Api.Controllers;

[Authorize]
[Route("api/ingredients")]
[ApiController]
public class IngredientsController : ControllerBase
{
    private readonly ILogger<IngredientsController> _logger;
    private readonly IIngredientRepository _ingredientRepo;
    private const int _maxPageSize = 40;

    public IngredientsController(ILogger<IngredientsController> logger, 
        IIngredientRepository ingredientRepo)
    {
        _logger = logger;
        _ingredientRepo = ingredientRepo;
    }

    [HttpGet("exist/{name}")]
    public async Task<ActionResult<bool>> NameExistAsync([FromRoute][MaxLength(50)] string name)
    {
        try
        {
            bool exist = await _ingredientRepo.NameExist(name);
            return Ok(exist);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While querying if ingredient name exist for name = {Name}, error = {Ex}", name ,ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpGet("nodescription")]
    public async Task<ActionResult<IEnumerable<IngredientNoDescDto>>> GetIngredientsNoDescAsync()
    {
        try
        {
            IEnumerable<Ingredient> ingredients = await _ingredientRepo.GetAllNoDescription();

            if (ingredients.Any() == false)
            {
                _logger.LogInformationGetAll(nameof(Ingredient));
                return NotFound();
            }

            IEnumerable<IngredientNoDescDto> response = ingredients.Select(i => i.MapToIngredientNoDescDto());
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAll(nameof(Ingredient), ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientDto>>> GetIngredients([FromQuery] int pageNumber, [FromQuery] int pageSize)
    {
        try
        {
            if (pageSize > _maxPageSize)
                pageSize = _maxPageSize;

            (IEnumerable<Ingredient> ingredients, PaginationMetadata metadata) =
                await _ingredientRepo.GetPage(pageNumber, pageSize);

            if (ingredients.Any() == false)
            {
                _logger.LogInformationGetAll(nameof(Ingredient));
                return NotFound();
            }

            IEnumerable<IngredientDto> response = ingredients.Select(i => i.MapToIngredientDto());

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAll(nameof(Ingredient), ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<IngredientDto>> GetIngredientById([FromRoute] int id)
    {
        try
        {
            DbResult<Ingredient> dbResult = await _ingredientRepo.Get(id);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(Ingredient), id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();
            

            return Ok(dbResult.Entity.MapToIngredientDto());
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGet(nameof(Ingredient), id, ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpPost]
    public async Task<ActionResult<IngredientDto>> CreateIngredient([FromBody] IngredientRequest createIngredientRequest)
    {
        try
        {
            Ingredient ingredient = new()
            {
                Name = createIngredientRequest.Name,
                Description = createIngredientRequest.Description,
                ModifiedOn = DateTime.UtcNow
            };

            DbResult<Ingredient> dbResult = await _ingredientRepo.Add(ingredient);

            if (dbResult.Status == Status.NameConflict)
            {
                _logger.LogInformationCreate(nameof(Ingredient), createIngredientRequest.Name);
                return BadRequest("The name already exists.");
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();

            IngredientDto response = dbResult.Entity.MapToIngredientDto();

            return CreatedAtAction(
                nameof(GetIngredientById),
                new { id = dbResult.Entity.Id },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalCreate(nameof(Ingredient), createIngredientRequest.Name, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateIngredient(
        [FromRoute] int id,
        [FromBody] IngredientRequest updateIngredientRequest)
    {
        try
        {
            Ingredient ingredient = new()
            {
                Id = id,
                Name = updateIngredientRequest.Name,
                Description = updateIngredientRequest.Description,
                ModifiedOn = DateTime.UtcNow
            };

            Status updateResult = await _ingredientRepo.Update(ingredient);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(Ingredient), id);
                return NotFound();
            }

            if (updateResult == Status.NameConflict)
            {
                _logger.LogInformation("Ingredient with id {Id} could not be updated. Name {Name} already exists.", id, updateIngredientRequest.Name);
                return BadRequest("Name already exists.");
            }

            if (updateResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalUpdate(nameof(Ingredient), id, ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteIngredient([FromRoute] int id)
    {
        try
        {
            Status deleteResult = await _ingredientRepo.Delete(id);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformationDelete(nameof(Ingredient), id);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalDelete(nameof(Ingredient), id, ex);
            return this.InternalErrorCustom();
        }
    }
}
