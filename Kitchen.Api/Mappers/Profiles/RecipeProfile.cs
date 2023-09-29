using AutoMapper;
using Kitchen.Entities.Entities;

namespace Kitchen.Api.Mappers.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDto>();
    }
}
