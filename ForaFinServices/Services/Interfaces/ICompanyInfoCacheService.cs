using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoCacheService
    {
        List<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter);

        Task CacheData(string cik);
    }
}
