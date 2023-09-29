using AutoMapper;
using Kitchen.Entities.Entities;

namespace Kitchen.Api.Mappers.Profiles;

public class IngredientProfile : Profile
{
    public IngredientProfile()
    {
        CreateMap<Ingredient, IngredientDto>();
        CreateMap<Ingredient, IngredientNoDescDto>();
    }
}
