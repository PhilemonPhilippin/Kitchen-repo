namespace Kitchen.Entities;

[Table(nameof(RecipeIngredient))]
public class RecipeIngredient
{
    public Guid IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }

    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
