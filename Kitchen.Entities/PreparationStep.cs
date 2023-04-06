namespace Kitchen.Entities;

[Table(nameof(PreparationStep))]
public class PreparationStep
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [Required]
    public int StepNumber { get; set; }

    [Required]
    [MaxLength(500)]
    public string Step { get; set; } = string.Empty;

    [ForeignKey("RecipeId")]
    public Recipe Recipe { get; set; }
    public Guid RecipeId { get; set; }

}
