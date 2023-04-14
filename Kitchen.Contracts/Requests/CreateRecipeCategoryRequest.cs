
using System.ComponentModel.DataAnnotations;

namespace Kitchen.Contracts.Requests;

public class CreateRecipeCategoryRequest
{
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }
}
