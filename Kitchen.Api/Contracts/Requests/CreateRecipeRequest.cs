namespace Kitchen.Api.Contracts.Requests;

public class CreateRecipeRequest
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public Guid RecipeCategoryId { get; set; }

}
