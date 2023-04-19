using Kitchen.Entities;

namespace Kitchen.Contracts.Dtos;

public class IngredientForSpecificRecipeDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string IngredientQuantity { get; set; } = string.Empty;
}
