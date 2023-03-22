using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kitchen.Entities;

[Table(nameof(RecipeCategory))]
public class RecipeCategory
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }

    public RecipeCategory(string title)
    {
        Title = title;
    }
}
