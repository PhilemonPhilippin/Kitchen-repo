namespace Kitchen.Entities;

[Table(nameof(Recipe))]
public class Recipe
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    [ForeignKey("RecipeCategoryId")]
    public RecipeCategory RecipeCategory { get; set; }
    public Guid RecipeCategoryId { get; set; }

    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

}
