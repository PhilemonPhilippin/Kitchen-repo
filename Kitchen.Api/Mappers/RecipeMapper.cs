using Kitchen.Api.Contracts.Requests;
using Kitchen.Core.Models;

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

    public static CreatedRecipeResponse MapCreatedRecipeResponse(this Recipe recipe)
    {
        return new CreatedRecipeResponse()
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            CreatedOn = recipe.CreatedOn,
            RecipeCategoryId = recipe.RecipeCategoryId,
        };
    }

    public static CreateRecipeModel MapCreateRecipeModel(this CreateRecipeRequest recipe)
    {
        return new CreateRecipeModel()
        {
            Title = recipe.Title,
            Description = recipe.Description,
            RecipeCategoryId = recipe.RecipeCategoryId,
        };
    }
}
