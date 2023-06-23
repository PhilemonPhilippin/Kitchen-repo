using System.ComponentModel.DataAnnotations;


namespace Kitchen.Contracts.Requests;

public record RecipeRequest([Required][MaxLength(50)] string Title,
                            [MaxLength(500)] string? Description,
                            [Required] Guid RecipeCategoryId);

public record IngredientRequest([Required][MaxLength(50)] string Name,
                                [MaxLength(500)] string? Description);

public record PreparationStepRequest([Required][MaxLength(50)] string Title,
                                    [Required] int StepNumber,
                                    [Required][MaxLength(500)] string Step);