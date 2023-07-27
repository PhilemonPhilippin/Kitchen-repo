using AutoMapper;
using Kitchen.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Kitchen.Api.Controllers;

[Route("api/ingredients")]
[ApiController]
public class IngredientsController : ControllerBase
{
    private readonly ILogger<IngredientsController> _logger;
    private readonly IMapper _mapper;
    private readonly IIngredientService _ingredientService;

    public IngredientsController(ILogger<IngredientsController> logger, IMapper mapper, IIngredientService ingredientService)
    {
        _logger = logger;
        _mapper = mapper;
        _ingredientService = ingredientService;
    }

    [HttpGet("exist/{name}")]
    public async Task<ActionResult<bool>> NameExistAsync([FromRoute][MaxLength(50)] string name)
    {
        try
        {
            bool exist = await _ingredientService.NameExist(name);
            return Ok(exist);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting the ingredients, error = {Ex}", ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("nodescription")]
    public async Task<ActionResult<IEnumerable<IngredientNoDescDto>>> GetIngredientsNoDescAsync()
    {
        try
        {
            IEnumerable<Ingredient> ingredients = await _ingredientService.GetAllNoDescription();

            if (ingredients is null || ingredients.Any() == false)
            {
                _logger.LogInformation("Ingredients were not found");
                return NotFound();
            }

            IEnumerable<IngredientNoDescDto> response = _mapper.Map<IEnumerable<IngredientNoDescDto>>(ingredients);
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting the ingredients, error = {Ex}", ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientDto>>> GetIngredients([FromQuery] int pageNumber, [FromQuery] int pageSize)
    {
        try
        {
            (IEnumerable<Ingredient> ingredients, PaginationMetadata metadata) =
                await _ingredientService.GetPage(pageNumber, pageSize);

            if (ingredients is null || ingredients.Any() == false)
            {
                _logger.LogInformation("Ingredients were not found");
                return NotFound();
            }

            IEnumerable<IngredientDto> response = _mapper.Map<IEnumerable<IngredientDto>>(ingredients);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting the ingredients, error = {Ex}", ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<IngredientDto>> GetIngredientById([FromRoute] int id)
    {
        try
        {
            DbResult<Ingredient> dbResult = await _ingredientService.Get(id);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformation("Ingredient with id {Id} was not found.", id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");
            

            return Ok(_mapper.Map<IngredientDto>(dbResult.Entity));
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting ingredient, for id = {Id}, error = {Ex}", id, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpPost]
    public async Task<ActionResult<IngredientDto>> CreateIngredient([FromBody] IngredientRequest createIngredientRequest)
    {
        try
        {
            DbResult<Ingredient> dbResult = await _ingredientService.Add(createIngredientRequest);

            if (dbResult.Status == Status.NameConflict)
            {
                _logger.LogInformation("Could not create the ingredient with name = {Name}", createIngredientRequest.Name);
                return BadRequest("The name already exists.");
            }

            if (dbResult.Status == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            IngredientDto response = _mapper.Map<IngredientDto>(dbResult.Entity);

            return CreatedAtAction(
                nameof(GetIngredientById),
                new { id = dbResult.Entity!.Id },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While creating ingredient, for ingredient name = {Name}, error = {Ex}", createIngredientRequest.Name, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateIngredient(
        [FromRoute] int id,
        [FromBody] IngredientRequest updateIngredientRequest)
    {
        try
        {
            Status updateResult = await _ingredientService.Update(id, updateIngredientRequest);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformation("Ingredient with id {Id} could not be found.", id);
                return NotFound();
            }

            if (updateResult == Status.NameConflict)
            {
                _logger.LogInformation("Ingredient with id {Id} could not be updated. Name {Name} already exists.", id, updateIngredientRequest.Name);
                return BadRequest("Name already exists.");
            }

            if (updateResult == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While updating ingredient, for ingredient id = {Id}, error = {Ex}", id, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteIngredient([FromRoute] int id)
    {
        try
        {
            Status deleteResult = await _ingredientService.Delete(id);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformation("Ingredient with id {Id} could not be deleted.", id);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return StatusCode(500, "A problem occured while handling the request.");

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While deleting ingredient, for ingredient id = {Id}, error = {Ex}", id, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
