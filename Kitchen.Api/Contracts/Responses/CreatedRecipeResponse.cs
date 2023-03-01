namespace Kitchen.Api.Contracts.Responses;

public class CreatedRecipeResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid RecipeCategoryId { get; set; }
}
