

namespace Kitchen.Contracts.Dtos;

public class RecipeCategoryDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
}
