namespace Kitchen.Entities.Entities;

[Table(nameof(Recipe))]
public class Recipe
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }
    [MaxLength(500)]
    public string? Image { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
    public Guid UniqueId { get; set; } = Guid.NewGuid();

    [ForeignKey("RecipeCategoryId")]
    public RecipeCategory RecipeCategory { get; set; }
    public int RecipeCategoryId { get; set; }

    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

}
