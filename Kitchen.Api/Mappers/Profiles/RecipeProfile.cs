using AutoMapper;

namespace Kitchen.Api.Mappers.Profiles;

public class RecipeProfile : Profile
{
    public RecipeProfile()
    {
        CreateMap<Recipe, RecipeDto>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.RecipeCategory.Title));
    }
}
