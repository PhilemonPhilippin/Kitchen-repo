namespace Kitchen.Api.Mappers.Customs;

public static class RecipeCategoryMapper
{
    public static RecipeCategoryDto MapToRecipeCategoryDto(this RecipeCategory recipeCategory)
    {
        return new RecipeCategoryDto()
        {
            Id = recipeCategory.Id,
            Title = recipeCategory.Title,
            Description = recipeCategory.Description
        };
    }
}
