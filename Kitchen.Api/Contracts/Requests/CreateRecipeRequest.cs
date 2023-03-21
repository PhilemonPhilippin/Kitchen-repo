using System.ComponentModel.DataAnnotations;

namespace Kitchen.Api.Contracts.Requests;

public class CreateRecipeRequest
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; }
    [Required]
    public Guid RecipeCategoryId { get; set; }

}
