using System.ComponentModel.DataAnnotations;

namespace Kitchen.Contracts.Requests;

public class UpdateRecipeIngredientRequest
{
    [Required]
    [MaxLength(50)]
    public string IngredientQuantity { get; set; }
}
