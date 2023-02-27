using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Kitchen.Entities;

[Table(nameof(RecipeCategory))]
public class RecipeCategory
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
}
