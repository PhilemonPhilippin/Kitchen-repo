﻿using AutoMapper;
using Kitchen.Models;
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
                return NotFound("Recipe not found.");
            }

            IEnumerable<PreparationStep> preparationSteps = await _preparationStepService.GetAll(recipeId);

            if (preparationSteps.Any() == false)
            {
                _logger.LogInformation("Preparation steps were not found.");
                return NotFound("Preparation steps not found.");
            }

            return Ok(_mapper.Map<IEnumerable<PreparationStepDto>>(preparationSteps));
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting preparation steps, for recipe id = {RecipeId}, error = {Ex}",recipeId, ex);
            return this.InternalErrorCustom();
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
                return NotFound("Recipe not found.");
            }

            DbResult<PreparationStep> dbResult = await _preparationStepService.Get(preparationStepId);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformation("Preparation step with id {PreparationStepId} was not found.", preparationStepId);
                return NotFound("Preparation step not found");
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();

            return Ok(_mapper.Map<PreparationStepDto>(dbResult.Entity));
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While getting a preparation step, for recipe id = {RecipeId} and preparation step id = {PreparationStepId}, error = {Ex}", recipeId, preparationStepId, ex);
            return this.InternalErrorCustom();
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
                return NotFound("Recipe not found.");
            }
            DbResult<PreparationStep> dbResult = await _preparationStepService.Add(recipeId, createPreparationStepRequest);

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformation("Could not create the preparation step with title = {Title}", createPreparationStepRequest.Title);
                return this.InternalErrorCustom();
            }

            PreparationStepDto response = _mapper.Map<PreparationStepDto>(dbResult.Entity);

            return CreatedAtAction(
                nameof(GetPreparationStep),
                new
                {
                    recipeId = recipeId,
                    preparationStepId = dbResult.Entity!.Id
                },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While creating a preparation step, for recipe id = {RecipeId} and preparation step title = {Title}, error = {Ex}", recipeId, createPreparationStepRequest.Title, ex);
            return this.InternalErrorCustom();
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
                return NotFound("Recipe not found.");
            }
             
            Status updateResult = await _preparationStepService.Update(recipeId, preparationStepId, updatePreparationStepRequest);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformation("Preparation step with id {PreparationStepId} could not be updated.", preparationStepId);
                return NotFound("Preparation step not found.");
            }

            if (updateResult  == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While updating a preparation step, for recipe id = {RecipeId} and preparation step id = {PreparationStepId}, error = {Ex}", recipeId, preparationStepId, ex);
            return this.InternalErrorCustom();
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
                return NotFound("Recipe not found.");
            }

            Status deleteResult = await _preparationStepService.Delete(preparationStepId);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformation("PreparationStep with id {PreparationStepId} could not be deleted.", preparationStepId);
                return NotFound("Preparation step not found.");
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While deleting a preparation step, for recipe id = {RecipeId} and preparation step id = {PreparationStepId}, error = {Ex}", recipeId, preparationStepId, ex);
            return this.InternalErrorCustom();
        }
    }
}
