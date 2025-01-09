using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Models;

namespace ForaFinServices.Bootstrap.MapProfiles;

public class CompanyInfoProfile : Profile
{
    public CompanyInfoProfile()
    { 
        CreateMap<CompanyInfo, CompanyInfoHeaderDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => !string.IsNullOrWhiteSpace(src.EntityName) ? src.EntityName : $"No Name - {src.Cik}"))
            .ForMember(dest => dest.Cik,
            opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.Cik.ToString()) && src.Cik.ToString()!.All(c => char.IsNumber(c)) 
            ? long.Parse(src.Cik.ToString()!) 
            : default));
        CreateMap<CompanyInfo, CompanyInfoDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => !string.IsNullOrWhiteSpace(src.EntityName) ? src.EntityName : $"No Name - {src.Cik}"))
            .ForMember(dest => dest.Cik,
            opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.Cik.ToString()) && src.Cik.ToString()!.All(c => char.IsNumber(c))
            ? long.Parse(src.Cik.ToString()!)
            : default));
    }
}
