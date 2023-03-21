using Kitchen.Contracts.Dtos;
using Kitchen.Contracts.Requests;

namespace Kitchen.Api.Mappers;

public static class RecipeMapper
{
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
