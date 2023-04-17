﻿using AutoMapper;
using Kitchen.Contracts.Requests;
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

    [HttpPost]
    public async Task<ActionResult<IngredientDto>> CreateIngredient([FromBody] CreateIngredientRequest createIngredientRequest)
    {
        try
        {
            Ingredient? ingredient = await _ingredientService.CreateIngredientAsync(createIngredientRequest);

            if (ingredient == null)
            {
                _logger.LogInformation($"Could not create the ingredient with name = {createIngredientRequest.Name}");
                return BadRequest();
            }

            IngredientDto response = _mapper.Map<IngredientDto>(ingredient);

            return CreatedAtAction(
                nameof(GetIngredientById),
                new { id = ingredient.Id },
                response);
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While creating ingredient, for ingredient name = {createIngredientRequest.Name}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
    [HttpPut("{id:GUid}")]
    public async Task<ActionResult> UpdateIngredient([FromRoute] Guid id, [FromBody] UpdateIngredientRequest updateIngredientRequest)
    {
        try
        {
            bool isUpdated = await _ingredientService.UpdateIngredientAsync(id, updateIngredientRequest);

            if (isUpdated == false)
            {
                _logger.LogInformation($"Ingredient with id {id} could not be updated.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While updating ingredient, for ingredient id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult> DeleteIngredient([FromRoute] Guid id)
    {
        try
        {
            bool isDeleted = await _ingredientService.DeleteIngredientAsync(id);

            if (isDeleted == false)
            {
                _logger.LogInformation($"Ingredient with id {id} could not be deleted.");
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogCritical($"While deleting ingredient, for ingredient id = {id}, error = {ex}");
            return StatusCode(500, "A problem occured while handling the request.");
        }
    }
}
