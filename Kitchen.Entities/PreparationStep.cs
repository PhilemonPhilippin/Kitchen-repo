using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(PreparationStep))]
public class PreparationStep
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Step { get; set; }

    [ForeignKey("RecipeId")]
    public Recipe Recipe { get; set; }
    public Guid RecipeId { get; set; }

    public PreparationStep(string title, string step)
    {
        Title = title;
        Step = step;
    }

}
