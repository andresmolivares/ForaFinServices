using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class UnitsProfile : Profile
{
    public UnitsProfile()
    {
        CreateMap<Units, UnitsDto>();
    }
}
