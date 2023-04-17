using AutoMapper;
using Kitchen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientDto>>> GetIngredients([FromQuery] int pageNumber, [FromQuery] int pageSize)
    {
        try
        {
            var ingredientsTuple = await _ingredientService.GetIngredientsAsync(pageNumber, pageSize);

            IEnumerable<Ingredient> ingredients = ingredientsTuple.Item1;
            PaginationMetadata metadata = ingredientsTuple.Item2;

            if (ingredients == null || ingredients.Count() == 0)
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
            _logger.LogCritical($"While getting the ingredients, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<IngredientDto>> GetIngredientById([FromRoute] Guid id)
    {
        try
        {
            Ingredient? ingredient = await _ingredientService.GetIngredientByIdAsync(id); 

            if (ingredient == null)
            {
                _logger.LogInformation($"Ingredient with id {id} was not found.");
                return NotFound();
            }

            return Ok(_mapper.Map<IngredientDto>(ingredient));
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting ingredient, for id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
