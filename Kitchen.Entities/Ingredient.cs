using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(Ingredient))]
public class Ingredient
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
}
