using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoCacheService
    {
        IEnumerable<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter);

        IEnumerable<EdgarCompanyInfo> GetCompanyInfoList();

        Task CacheData(string cik);
    }
}
