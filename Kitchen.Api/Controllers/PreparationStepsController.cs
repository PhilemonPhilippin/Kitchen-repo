﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipes/{recipeId:int}/preparationsteps")]
[ApiController]
public class PreparationStepsController : ControllerBase
{
    private readonly ILogger<PreparationStepsController> _logger;
    private readonly IPreparationStepService _preparationStepService;
    private readonly IRecipeService _recipeService;
    private readonly IMapper _mapper;

    public PreparationStepsController(
        ILogger<PreparationStepsController> logger,
        IMapper mapper,
        IPreparationStepService preparationStepService,
        IRecipeService recipeService)
    {
        _logger = logger;
        _mapper = mapper;
        _preparationStepService = preparationStepService;
        _recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PreparationStepDto>>> GetPreparationSteps([FromRoute] int recipeId)
    {
        try
        {
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation("Recipe with id {RecipeId} was not found when accessing Preparation steps.", recipeId);
                return NotFound();
            }

            IEnumerable<PreparationStep> preparationSteps = await _preparationStepService.GetAll(recipeId);
            return Ok(_mapper.Map<IEnumerable<PreparationStepDto>>(preparationSteps));
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting preparation steps, for recipe id = {RecipeId}, error = {Ex}",recipeId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpGet("{preparationstepid:int}")]
    public async Task<ActionResult<PreparationStepDto>> GetPreparationStep(
        [FromRoute] int recipeId,
        [FromRoute] int preparationStepId)
    {
        try
        {
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation("Recipe with id {RecipeId} was not found when accessing Preparation step.", recipeId);
                return NotFound();
            }

            PreparationStep? preparationStep = await _preparationStepService.Get(preparationStepId);

            if (preparationStep is null)
            {
                _logger.LogInformation("Preparation step with id {PreparationStepId} was not found.", preparationStepId);
                return NotFound();
            }
            return Ok(_mapper.Map<PreparationStepDto>(preparationStep));
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting a preparation step, for recipe id = {RecipeId} and preparation step id = {PreparationStepId}, error = {Ex}", recipeId, preparationStepId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPost]
    public async Task<ActionResult<PreparationStepDto>> CreatePreparationStep(
        [FromRoute] int recipeId,
        [FromBody] PreparationStepRequest createPreparationStepRequest)
    {
        try
        {
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation("Recipe with id {RecipeId} was not found when creating Preparation step.", recipeId);
                return NotFound();
            }
            PreparationStep? preparationStep = await _preparationStepService.Add(recipeId, createPreparationStepRequest);

            if (preparationStep is null)
            {
                _logger.LogInformation("Could not create the preparation step with title = {Title}", createPreparationStepRequest.Title);
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
            _logger.LogCritical("While creating a preparation step, for recipe id = {RecipeId} and preparation step title = {Title}, error = {Ex}", recipeId, createPreparationStepRequest.Title, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPut("{preparationstepid:int}")]
    public async Task<ActionResult> UpdatePreparationStep(
        [FromRoute] int recipeId,
        [FromRoute] int preparationStepId,
        [FromBody] PreparationStepRequest updatePreparationStepRequest)
    {
        try
        {
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation("Recipe with id {RecipeId} was not found when updating Preparation step.", recipeId);
                return NotFound();
            }
             
            bool isUpdated = await _preparationStepService.Update(recipeId, preparationStepId, updatePreparationStepRequest);

            if (isUpdated == false)
            {
                _logger.LogInformation("Preparation step with id {PreparationStepId} could not be updated.", preparationStepId);
                return NotFound();
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While updating a preparation step, for recipe id = {RecipeId} and preparation step id = {PreparationStepId}, error = {Ex}", recipeId, preparationStepId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpDelete("{preparationstepid:int}")]
    public async Task<ActionResult> DeletePreparationStep(
        [FromRoute] int recipeId,
        [FromRoute] int preparationStepId)
    {
        try
        {
            bool recipeExists = await _recipeService.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformation("Recipe with id {RecipeId} was not found when deleting Preparation step.", recipeId);
                return NotFound();
            }

            bool isDeleted = await _preparationStepService.Delete(preparationStepId);

            if (isDeleted == false)
            {
                _logger.LogInformation("PreparationStep with id {PreparationStepId} could not be deleted.", preparationStepId);
                return NotFound();
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While deleting a preparation step, for recipe id = {RecipeId} and preparation step id = {PreparationStepId}, error = {Ex}", recipeId, preparationStepId, ex.Message);
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
