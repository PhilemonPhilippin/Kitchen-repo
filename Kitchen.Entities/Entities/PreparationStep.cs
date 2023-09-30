namespace Kitchen.Entities.Entities;

[Table(nameof(PreparationStep))]
public class PreparationStep
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [Required]
    public int StepNumber { get; set; }

    [Required]
    [MaxLength(500)]
    public string Step { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedOn { get; set; }
    public Guid UniqueId { get; set; } = Guid.NewGuid();

    [ForeignKey("RecipeId")]
    public Recipe Recipe { get; set; }
    public int RecipeId { get; set; }

}
