namespace Kitchen.Core.Models;

public class UpdateRecipeModel
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid RecipeCategoryId { get; set; }
}
