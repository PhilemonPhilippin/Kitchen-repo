using AutoMapper;
using Kitchen.Entities.Entities;

namespace Kitchen.Api.Mappers.Profiles;

public class RecipeCategoryProfile : Profile
{
    public RecipeCategoryProfile()
    {
        CreateMap<RecipeCategory, RecipeCategoryDto>();
    }
}
