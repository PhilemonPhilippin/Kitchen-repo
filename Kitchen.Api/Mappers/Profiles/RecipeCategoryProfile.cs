using AutoMapper;

namespace Kitchen.Api.Mappers.Profiles;

public class RecipeCategoryProfile : Profile
{
    public RecipeCategoryProfile()
    {
        CreateMap<RecipeCategory, RecipeCategoryDto>();
    }
}
