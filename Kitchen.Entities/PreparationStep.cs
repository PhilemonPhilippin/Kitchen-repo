using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(PreparationStep))]
public class PreparationStep
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Step { get; set; } = string.Empty;

    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }

}
