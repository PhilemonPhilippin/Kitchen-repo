using System.ComponentModel.DataAnnotations;

namespace Kitchen.Contracts.Requests;

public class CreateRecipeIngredientRequest
{
    [Required]
    public Guid IngredientId { get; set; }
    [Required]
    [MaxLength(50)]
    public string IngredientQuantity { get; set; }
}
