using AutoMapper;

namespace Kitchen.Api.Mappers.Profiles;

public class PreparationStepProfile : Profile
{
    public PreparationStepProfile()
    {
        CreateMap<PreparationStep, PreparationStepDto>();
    }
}
