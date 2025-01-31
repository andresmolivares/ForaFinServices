using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class FinancialResourceProfile : Profile
{
    public FinancialResourceProfile()
    {
        CreateMap<FinancialResource, FinancialResourceHeaderDto>();
        CreateMap<FinancialResource, FinancialResourceDto>();
    }
}
