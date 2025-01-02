using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class UsGaapProfile : Profile
{
    public UsGaapProfile()
    {
        CreateMap<UsGaap, UsGaapDto>();
    }
}
