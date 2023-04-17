using AutoMapper;
using Kitchen.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipeingredients")]
[ApiController]
public class RecipeIngredientsController : ControllerBase
{
    private readonly ILogger<RecipeIngredientsController> _logger;
    private readonly IMapper _mapper;
    private readonly IRecipeIngredientService _recipeIngredientService;

    public RecipeIngredientsController(ILogger<RecipeIngredientsController> logger, IMapper mapper, IRecipeIngredientService recipeIngredientService)
    {
        _logger = logger;
        _mapper = mapper;
        _recipeIngredientService = recipeIngredientService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeIngredientDto>>> GetRecipeIngredients()
    {
        throw new NotImplementedException();
    }
}
