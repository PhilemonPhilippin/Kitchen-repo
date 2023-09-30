namespace Kitchen.Entities.Entities;

[Table(nameof(RecipeCategory))]
public class RecipeCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedOn { get; set; }
    public Guid UniqueId { get; set; } = Guid.NewGuid();
}
