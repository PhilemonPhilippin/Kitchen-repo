using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Route("api/recipes/{recipeId:int}/preparationsteps")]
[ApiController]
public class PreparationStepsController : ControllerBase
{
    private readonly ILogger<PreparationStepsController> _logger;
    //private readonly IPreparationStepService _preparationStepService;
    private readonly IPreparationStepRepository _preparationStepRepo;
    private readonly IRecipeRepository _recipeRepo;
    //private readonly IRecipeService _recipeService;
    private readonly IMapper _mapper;

    public PreparationStepsController(
        ILogger<PreparationStepsController> logger,
        IMapper mapper,
        //IPreparationStepService preparationStepService,
        IPreparationStepRepository preparationStepRepo,
        IRecipeRepository recipeRepo)
        //IRecipeService recipeService)
    {
        _logger = logger;
        _mapper = mapper;
        //_preparationStepService = preparationStepService;
        _preparationStepRepo = preparationStepRepo;
        _recipeRepo = recipeRepo;
        //_recipeService = recipeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PreparationStepDto>>> GetPreparationSteps([FromRoute] int recipeId)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            IEnumerable<PreparationStep> preparationSteps = await _preparationStepRepo.GetAll(recipeId);

            if (preparationSteps.Any() == false)
            {
                _logger.LogInformationGetAll(nameof(PreparationStep));
                return NotFound("Preparation steps not found.");
            }

            return Ok(_mapper.Map<IEnumerable<PreparationStepDto>>(preparationSteps));
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAllForSpecificRecipe(nameof(PreparationStep), recipeId, ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpGet("{preparationStepId:int}")]
    public async Task<ActionResult<PreparationStepDto>> GetPreparationStep(
        [FromRoute] int recipeId,
        [FromRoute] int preparationStepId)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            DbResult<PreparationStep> dbResult = await _preparationStepRepo.Get(preparationStepId);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(PreparationStep), preparationStepId);
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
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            PreparationStep preparationStep = new()
            {
                Title = createPreparationStepRequest.Title,
                Step = createPreparationStepRequest.Step,
                StepNumber = (int)createPreparationStepRequest.StepNumber,
                RecipeId = recipeId,
                ModifiedOn = DateTime.UtcNow
            };

            DbResult<PreparationStep> dbResult = await _preparationStepRepo.Add(preparationStep);

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformationCreate(nameof(PreparationStep), createPreparationStepRequest.Title);
                return this.InternalErrorCustom();
            }

            PreparationStepDto response = _mapper.Map<PreparationStepDto>(dbResult.Entity);

            return CreatedAtAction(
                nameof(GetPreparationStep),
                new
                {
                    recipeId = recipeId,
                    preparationStepId = dbResult.Entity.Id
                },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical("While creating a preparation step, for recipe id = {RecipeId} and preparation step title = {Title}, error = {Ex}", recipeId, createPreparationStepRequest.Title, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPut("{preparationStepId:int}")]
    public async Task<ActionResult> UpdatePreparationStep(
        [FromRoute] int recipeId,
        [FromRoute] int preparationStepId,
        [FromBody] PreparationStepRequest updatePreparationStepRequest)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            PreparationStep preparationStep = new()
            {
                Id = preparationStepId,
                Title = updatePreparationStepRequest.Title,
                Step = updatePreparationStepRequest.Step,
                StepNumber = (int)updatePreparationStepRequest.StepNumber,
                RecipeId = recipeId,
                ModifiedOn = DateTime.UtcNow
            };

            Status updateResult = await _preparationStepRepo.Update(preparationStep);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformationUpdate(nameof(PreparationStep), preparationStepId);
                return NotFound("Preparation step not found.");
            }

            if (updateResult  == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalUpdateForSpecificRecipe(nameof(PreparationStep), recipeId, preparationStepId, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpDelete("{preparationStepId:int}")]
    public async Task<ActionResult> DeletePreparationStep(
        [FromRoute] int recipeId,
        [FromRoute] int preparationStepId)
    {
        try
        {
            bool recipeExists = await _recipeRepo.IdExist(recipeId);

            if (recipeExists == false)
            {
                _logger.LogInformationGet(nameof(Recipe), recipeId);
                return NotFound("Recipe not found.");
            }

            Status deleteResult = await _preparationStepRepo.Delete(preparationStepId);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformationDelete(nameof(PreparationStep), preparationStepId);
                return NotFound("Preparation step not found.");
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalDeleteForSpecificRecipe(nameof(PreparationStep), recipeId, preparationStepId, ex);
            return this.InternalErrorCustom();
        }
    }
}
