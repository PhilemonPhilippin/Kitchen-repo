using System.ComponentModel.DataAnnotations;

namespace Kitchen.Contracts.Requests;

public class CreateRecipeIngredientRequest
{
    public Guid? Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; }
    [Required]
    [MaxLength(50)]
    public string IngredientQuantity { get; set; }
}
