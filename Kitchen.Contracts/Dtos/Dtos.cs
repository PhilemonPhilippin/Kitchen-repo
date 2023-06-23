namespace Kitchen.Contracts.Dtos;

public record IngredientDto(Guid Id, string Name, string? Description);

public record PreparationStepDto(Guid Id, string Title, int StepNumber, string Step, Guid RecipeId);

public record RecipeCategoryDto(Guid Id, string Title, string? Description);

public record RecipeDto(Guid Id, string Title, string? Description, RecipeCategoryDto RecipeCategory);

public record IngredientForSpecificRecipeDto(Guid Id, string Name, string? Description, string IngredientQuantity);