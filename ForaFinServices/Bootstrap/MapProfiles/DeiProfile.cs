using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class DeiProfile : Profile
{
    public DeiProfile()
    {
        CreateMap<Dei, DeiDto>();
    }
}
