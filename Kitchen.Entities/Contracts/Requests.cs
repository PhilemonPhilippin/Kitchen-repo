﻿namespace Kitchen.Entities.Contracts;

public record RecipeRequest(
    [Required][MaxLength(50)] string Title,
    [MaxLength(500)] string? Description,
    [Required] int? RecipeCategoryId);

public record IngredientRequest(
    [Required][MaxLength(50)] string Name,
    [MaxLength(500)] string? Description);

public record PreparationStepRequest(
    [Required][MaxLength(50)] string Title,
    [Required] int? StepNumber,
    [Required][MaxLength(500)] string Step);

public record RecipeCategoryRequest(
    [Required][MaxLength(50)] string Title,
    [MaxLength(500)] string? Description);

public record UpdateRecipeIngredientRequest(
    [Required][MaxLength(50)] string IngredientQuantity);
public record CreateRecipeIngredientRequest(
    [Required] int? IngredientId,
    [Required][MaxLength(50)] string IngredientQuantity);