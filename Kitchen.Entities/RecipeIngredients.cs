namespace Kitchen.Entities;

[Table(nameof(RecipeIngredients))]
public class RecipeIngredients
{
    public Guid IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }

    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
