namespace Kitchen.Api.Mappers;

public static class RecipeMapper
{
    public static RecipeResponse Map(this Recipe recipe)
    {
        return new RecipeResponse()
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            CreatedOn = recipe.CreatedOn,
            RecipeCategoryId = recipe.RecipeCategoryId,
            RecipeCategory = recipe.RecipeCategory,
            PreparationSteps = recipe.PreparationSteps,
            IngredientRecipes = recipe.IngredientRecipes
        };
    }
}
