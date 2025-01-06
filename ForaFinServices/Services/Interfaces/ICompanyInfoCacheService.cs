using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoCacheService
    {
        Task CacheData(string cik);

        IEnumerable<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter);

        IEnumerable<EdgarCompanyInfo> GetCompanyInfoList();

        EdgarCompanyInfo? GetCompanyInfoById(string cikId);
    }
}
