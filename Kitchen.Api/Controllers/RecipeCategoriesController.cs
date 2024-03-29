﻿using Kitchen.Api.Mappers.Customs;
using Microsoft.AspNetCore.Mvc;

namespace Kitchen.Api.Controllers;

[Authorize]
[Route("api/recipecategories")]
[ApiController]
public class RecipeCategoriesController : ControllerBase
{
    private readonly ILogger<RecipeCategoriesController> _logger;
    private readonly IRecipeCategoryRepository _recipeCategoryRepo;

    public RecipeCategoriesController(
        ILogger<RecipeCategoriesController> logger,
        IRecipeCategoryRepository recipeCategoryRepo)
    {
        _logger = logger;
        _recipeCategoryRepo = recipeCategoryRepo;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeCategoryDto>>> GetRecipeCategories()
    {
        try
        {
            IEnumerable<RecipeCategory> recipeCategories = await _recipeCategoryRepo.GetAll();

            if (recipeCategories.Any() == false)
            {
                _logger.LogInformationGetAll(nameof(RecipeCategory));
                return NotFound();
            }
            IEnumerable<RecipeCategoryDto> response = recipeCategories.Select(rc => rc.MapToRecipeCategoryDto());
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGetAll(nameof(RecipeCategory), ex);
            return this.InternalErrorCustom();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<RecipeCategoryDto>> GetRecipeCategoryById([FromRoute] int id)
    {
        try
        {
            DbResult<RecipeCategory> dbResult = await _recipeCategoryRepo.Get(id);

            if (dbResult.Status == Status.NotFound)
            {
                _logger.LogInformationGet(nameof(RecipeCategory), id);
                return NotFound();
            }

            if (dbResult.Status == Status.Error)
                return this.InternalErrorCustom();

            return Ok(dbResult.Entity.MapToRecipeCategoryDto());
        }
        catch (Exception ex)
        {
            _logger.LogCriticalGet(nameof(RecipeCategory), id, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPost]
    public async Task<ActionResult<RecipeCategoryDto>> CreateRecipeCategory(
        [FromBody] RecipeCategoryRequest createRecipeCategoryRequest)
    {
        try
        {
            RecipeCategory recipeCategory = new()
            {
                Title = createRecipeCategoryRequest.Title,
                Description = createRecipeCategoryRequest.Description
            };

            DbResult<RecipeCategory> dbResult = await _recipeCategoryRepo.Add(recipeCategory);

            if (dbResult.Status == Status.Error)
            {
                _logger.LogInformationCreate(nameof(RecipeCategory), createRecipeCategoryRequest.Title);
                return this.InternalErrorCustom();
            }

            RecipeCategoryDto response = dbResult.Entity.MapToRecipeCategoryDto();

            return CreatedAtAction(
                    nameof(GetRecipeCategoryById),
                    new { id = dbResult.Entity.Id },
                    response
                );
        }
        catch (Exception ex)
        {
            _logger.LogCriticalCreate(nameof(RecipeCategory), createRecipeCategoryRequest.Title, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateRecipeCategory(
        [FromRoute] int id,
        [FromBody] RecipeCategoryRequest updateRecipeCategoryRequest)
    {
        try
        {
            RecipeCategory recipeCategory = new()
            {
                Id = id,
                Title = updateRecipeCategoryRequest.Title,
                Description = updateRecipeCategoryRequest.Description,
                ModifiedOn = DateTime.UtcNow
            };

            Status updateResult = await _recipeCategoryRepo.Update(recipeCategory);

            if (updateResult == Status.NotFound)
            {
                _logger.LogInformationUpdate(nameof(RecipeCategory), id);
                return NotFound();
            }

            if (updateResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalUpdate(nameof(RecipeCategory), id, ex);
            return this.InternalErrorCustom();
        }
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteRecipeCategory([FromRoute] int id)
    {
        try
        {
            Status deleteResult = await _recipeCategoryRepo.Delete(id);

            if (deleteResult == Status.NotFound)
            {
                _logger.LogInformationDelete(nameof(RecipeCategory), id);
                return NotFound();
            }

            if (deleteResult == Status.Error)
                return this.InternalErrorCustom();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCriticalDelete(nameof(RecipeCategory), id, ex);
            return this.InternalErrorCustom();
        }
    }
}
