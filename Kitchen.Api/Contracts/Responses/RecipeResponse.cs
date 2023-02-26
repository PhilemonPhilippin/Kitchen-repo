namespace Kitchen.Api.Contracts.Responses;

public class RecipeResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }

    public Guid RecipeCategoryId { get; set; }
    public RecipeCategory RecipeCategory { get; set; }

    public ICollection<PreparationStep> PreparationSteps { get; set; }

    public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
}
