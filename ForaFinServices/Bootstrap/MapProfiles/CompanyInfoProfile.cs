using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class CompanyInfoProfile : Profile
{
    public CompanyInfoProfile()
    { 
        CreateMap<CompanyInfo, CompanyInfoDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.EntityName))
            .ForMember(dest => dest.Cik,
            opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.Cik.ToString()) && src.Cik.ToString()!.All(c => char.IsNumber(c)) 
            ? long.Parse(src.Cik.ToString()!) 
            : default));
        CreateMap<CompanyInfo, CompanyInfoDetailsDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.EntityName))
            .ForMember(dest => dest.Cik,
            opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.Cik.ToString()) && src.Cik.ToString()!.All(c => char.IsNumber(c))
            ? long.Parse(src.Cik.ToString()!)
            : default));
    }
}
