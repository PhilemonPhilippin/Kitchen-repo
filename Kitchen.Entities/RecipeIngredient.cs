namespace Kitchen.Entities;

[Table(nameof(RecipeIngredient))]
public class RecipeIngredient
{
    public int IngredientId{ get; set; }
    public Ingredient Ingredient { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    [Required]
    [MaxLength(50)]
    public string IngredientQuantity { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedOn { get; set; }
    public Guid UniqueId { get; set; } = Guid.NewGuid();
}
