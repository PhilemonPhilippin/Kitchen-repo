using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(Recipe))]
public class Recipe
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }

    [ForeignKey("RecipeCategoryId")]
    public RecipeCategory RecipeCategory { get; set; }
    public Guid RecipeCategoryId { get; set; }

    public ICollection<IngredientRecipe> IngredientRecipes { get; set; } = new List<IngredientRecipe>();

    public Recipe(string title)
    {
        Title = title;
    }

}
