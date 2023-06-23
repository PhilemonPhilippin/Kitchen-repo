namespace Kitchen.Api.Mappers.Customs;

public static class RecipeIngredientMapper
{

    public static IngredientForSpecificRecipeDto MapForSpecificRecipeDto(this RecipeIngredient recipeIngredient)
    {
        return new IngredientForSpecificRecipeDto(recipeIngredient.IngredientId,
                                                recipeIngredient.Ingredient.Name, 
                                                recipeIngredient.Ingredient.Description, 
                                                recipeIngredient.IngredientQuantity);
    }
}
