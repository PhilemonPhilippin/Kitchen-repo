using Kitchen.Api.Contracts.Dtos;
using Kitchen.Api.Contracts.Requests;
using Kitchen.Core.Models;

namespace Kitchen.Api.Mappers;

public static class RecipeMapper
{
    public static CreateRecipeModel MapCreateRecipeModel(this CreateRecipeRequest recipe)
    {
        return new CreateRecipeModel()
        {
            Title = recipe.Title,
            Description = recipe.Description,
            RecipeCategoryId = recipe.RecipeCategoryId,
        };
    }

    public static RecipeDto MapToRecipeDto(this Recipe recipe)
    {
        return new RecipeDto()
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            CreatedOn = recipe.CreatedOn,
            Category = recipe.RecipeCategory.Title,
        };
    }
}
