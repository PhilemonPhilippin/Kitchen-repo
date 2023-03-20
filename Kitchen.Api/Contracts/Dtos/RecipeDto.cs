namespace Kitchen.Api.Contracts.Dtos;

public class RecipeDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }
    public string Category { get; set; } = string.Empty;
}
