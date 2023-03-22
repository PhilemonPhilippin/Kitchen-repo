namespace Kitchen.Entities;

[Table(nameof(Ingredient))]
public class Ingredient
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }

    public ICollection<IngredientRecipe> IngredientRecipes { get; set; } = new List<IngredientRecipe>();
}
