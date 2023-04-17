using System.ComponentModel.DataAnnotations;

namespace Kitchen.Contracts.Requests;

public class CreateIngredientRequest
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }
}
