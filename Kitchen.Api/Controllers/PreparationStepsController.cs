﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
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

    [HttpGet("{preparationStepId:Guid}")]
    public async Task<ActionResult<PreparationStepDto>> GetPreparationStep(Guid recipeId, Guid preparationStepId)
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
}
