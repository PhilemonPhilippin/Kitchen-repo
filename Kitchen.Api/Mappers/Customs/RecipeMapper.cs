namespace Kitchen.Api.Mappers.Customs;

public static class RecipeMapper
{
    public static RecipeDto MapToRecipeDto(this Recipe recipe)
    {

        return new RecipeDto(recipe.Id,
                            recipe.Title,
                            recipe.Description,
                            new RecipeCategoryDto(recipe.RecipeCategory.Id,
                                                recipe.RecipeCategory.Title,
                                                recipe.RecipeCategory.Description));
    }
}
