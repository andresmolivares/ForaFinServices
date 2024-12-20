using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoCacheService
    {
        IEnumerable<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter);

        Task CacheData(string cik);
    }
}
