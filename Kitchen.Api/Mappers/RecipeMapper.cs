namespace Kitchen.Api.Mappers;

public static class RecipeMapper
{
    public static RecipeResponse MapRecipeResponse(this Recipe recipe)
    {
        return new RecipeResponse()
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            CreatedOn = recipe.CreatedOn,
            RecipeCategory = recipe.RecipeCategory,
        };
    }
}
