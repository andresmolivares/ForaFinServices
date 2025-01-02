using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class FactsProfile : Profile
{
    public FactsProfile()
    {
        CreateMap<Facts, FactsDto>();
    }
}
