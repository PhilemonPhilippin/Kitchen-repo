namespace Kitchen.Api.Mappers.Customs;

public static class RecipeMapper
{
    public static RecipeDto MapToRecipeDto(this Recipe recipe)
    {
        return new RecipeDto()
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            RecipeCategory = new() 
            { 
                Id = recipe.RecipeCategory.Id,
                Title = recipe.RecipeCategory.Title,
                Description = recipe.RecipeCategory.Description
            }
        };
    }
}
