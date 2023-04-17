using Kitchen.Entities;

namespace Kitchen.Contracts.Dtos;

public class RecipeIngredientDto
{
    public Ingredient Ingredient { get; set; }
    public Recipe Recipe { get; set; }
}
