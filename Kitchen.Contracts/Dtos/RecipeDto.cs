using Kitchen.Entities;

namespace Kitchen.Contracts.Dtos;

public class RecipeDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public RecipeCategoryDto RecipeCategory { get; set; }
}
