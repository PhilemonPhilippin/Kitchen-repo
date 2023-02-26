using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(IngredientRecipe))]
public class IngredientRecipe
{
    public Guid IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }

    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
