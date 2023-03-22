using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(Ingredient))]
public class Ingredient
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<IngredientRecipe> IngredientRecipes { get; set; } = new List<IngredientRecipe>();

    public Ingredient(string name)
    {
        Name = name;
    }
}
