using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoCacheService
    {
        Task CacheData(string cik);

        IEnumerable<CompanyInfo> GetCompanyInfo(string? letterFilter);

        IEnumerable<CompanyInfo> GetCompanyInfoList();

        CompanyInfo? GetCompanyInfoById(string cikId);
    }
}
