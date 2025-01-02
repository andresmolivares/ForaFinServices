using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class FinancialUnitProfile : Profile
{
    public FinancialUnitProfile()
    {
        CreateMap<BaseFinancialUnit, FinancialUnitDto>();
    }
}
