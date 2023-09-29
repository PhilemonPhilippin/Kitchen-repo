using Kitchen.Entities.Entities;

namespace Kitchen.Api.Mappers.Customs;

public static class RecipeIngredientMapper
{

    public static IngredientForSpecificRecipeDto MapForSpecificRecipeDto(this RecipeIngredient recipeIngredient)
    {
        return new IngredientForSpecificRecipeDto
        {
            Id = recipeIngredient.IngredientId,
            Name = recipeIngredient.Ingredient.Name,
            Description = recipeIngredient.Ingredient.Description,
            IngredientQuantity = recipeIngredient.IngredientQuantity
        };
    }
}
