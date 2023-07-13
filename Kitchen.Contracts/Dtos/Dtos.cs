namespace Kitchen.Contracts.Dtos;

public record IngredientDto(
    int Id, 
    string Name, 
    string? Description);

public record IngredientNoDescDto(
    int Id,
    string Name);

public record PreparationStepDto(
    int Id, 
    string Title, 
    int StepNumber, 
    string Step,
    int RecipeId);

public record RecipeCategoryDto(
    int Id, 
    string Title, 
    string? Description);

public record RecipeDto(
    int Id, 
    string Title, 
    string? Description, 
    RecipeCategoryDto RecipeCategory);

public record IngredientForSpecificRecipeDto(
    int Id, 
    string Name, 
    string? Description, 
    string IngredientQuantity);