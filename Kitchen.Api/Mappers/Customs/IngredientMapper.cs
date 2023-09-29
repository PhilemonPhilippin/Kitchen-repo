namespace Kitchen.Api.Mappers.Customs;

public static class IngredientMapper
{
    public static IngredientDto MapToIngredientDto(this Ingredient ingredient)
    {
        return new IngredientDto()
        {
            Id = ingredient.Id,
            Name = ingredient.Name,
            Description = ingredient.Description,
        };
    }

    public static IngredientNoDescDto MapToIngredientNoDescDto(this Ingredient ingredient)
    {
        return new IngredientNoDescDto()
        {
            Id = ingredient.Id,
            Name = ingredient.Name,
        };
    }
}
