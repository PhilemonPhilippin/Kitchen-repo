using AutoMapper;

namespace Kitchen.Api.Mappers.Profiles;

public class IngredientProfile : Profile
{
    public IngredientProfile()
    {
        CreateMap<Ingredient, IngredientDto>();
        CreateMap<Ingredient, IngredientNoDescDto>();
    }
}
