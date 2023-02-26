using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(Recipe))]
public class Recipe
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }

    public Guid RecipeCategoryId { get; set; }
    public RecipeCategory RecipeCategory { get; set; }

    public ICollection<IngredientRecipe> IngredientRecipes { get; set; }

}
