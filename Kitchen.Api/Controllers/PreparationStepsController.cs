using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipes/{recipeId:Guid}/preparationsteps")]
[ApiController]
public class PreparationStepsController : ControllerBase
{
    private readonly ILogger<PreparationStepsController> _logger;
    private readonly IPreparationStepService _preparationStepService;
    private readonly IRecipeService _recipeService;
    private readonly IMapper _mapper;

    public PreparationStepsController(ILogger<PreparationStepsController> logger, IMapper mapper, IPreparationStepService preparationStepService, IRecipeService recipeService)
    {
        _logger = logger;
        _mapper = mapper;
        _preparationStepService = preparationStepService;
        _recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PreparationStepDto>>> GetPreparationSteps([FromRoute] Guid recipeId)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when accessing Preparation steps.");
                return NotFound();
            }

            IEnumerable<PreparationStep> preparationSteps = await _preparationStepService.GetPreparationStepsAsync(recipeId);

            return Ok(_mapper.Map<IEnumerable<PreparationStepDto>>(preparationSteps));
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting preparation steps, for recipe id = {recipeId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("{preparationstepid:Guid}")]
    public async Task<ActionResult<PreparationStepDto>> GetPreparationStep(
        [FromRoute] Guid recipeId, [FromRoute] Guid preparationStepId)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when accessing Preparation step.");
                return NotFound();
            }

            PreparationStep? preparationStep = await _preparationStepService.GetPreparationStepAsync(recipeId, preparationStepId);

            if (preparationStep == null)
            {
                _logger.LogInformation($"Preparation step with id {preparationStepId} was not found.");
                return NotFound();
            }

            return Ok(_mapper.Map<PreparationStepDto>(preparationStep));
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While getting a preparation step, for recipe id = {recipeId} and preparation step id = {preparationStepId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPost]
    public async Task<ActionResult<PreparationStepDto>> CreatePreparationStep(
        [FromRoute] Guid recipeId, [FromBody] PreparationStepRequest createPreparationStepRequest)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when creating Preparation step.");
                return NotFound();
            }
            PreparationStep? preparationStep = await _preparationStepService.CreatePreparationStepAsync(recipeId, createPreparationStepRequest);

            if (preparationStep == null)
            {
                _logger.LogInformation($"Could not create the preparation step with title = {createPreparationStepRequest.Title}");
                return BadRequest();
            }

            PreparationStepDto response = _mapper.Map<PreparationStepDto>(preparationStep);
            return CreatedAtAction(
                nameof(GetPreparationStep),
                new
                {
                    recipeId = recipeId,
                    preparationStepId = preparationStep.Id
                },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While creating a preparation step, for recipe id = {recipeId} and preparation step title = {createPreparationStepRequest.Title}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPut("{preparationstepid:Guid}")]
    public async Task<ActionResult> UpdatePreparationStep(
        [FromRoute] Guid recipeId, [FromRoute] Guid preparationStepId,
        [FromBody] PreparationStepRequest updatePreparationStepRequest)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when updating Preparation step.");
                return NotFound();
            }

            bool isUpdated = await _preparationStepService
                .UpdatePreparationStepAsync(recipeId, preparationStepId, updatePreparationStepRequest);

            if (isUpdated == false)
            {
                _logger.LogInformation($"Preparation step with id {preparationStepId} could not be updated.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While updating a preparation step, for recipe id = {recipeId} and preparation step id = {preparationStepId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpDelete("{preparationstepid:Guid}")]
    public async Task<ActionResult> DeletePreparationStep(
        [FromRoute] Guid recipeId, [FromRoute] Guid preparationStepId)
    {
        try
        {
            bool recipeExists = await _recipeService.RecipeExistsAsync(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation($"Recipe with id {recipeId} was not found when deleting Preparation step.");
                return NotFound();
            }

            bool isDeleted = await _preparationStepService.DeletePreparationStepAsync(recipeId, preparationStepId);

            if (isDeleted == false)
            {
                _logger.LogInformation($"PreparationStep with id {preparationStepId} could not be deleted.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While deleting a preparation step, for recipe id = {recipeId} and preparation step id = {preparationStepId}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
