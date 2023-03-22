namespace Kitchen.Entities;

[Table(nameof(RecipeCategory))]
public class RecipeCategory
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }
}
