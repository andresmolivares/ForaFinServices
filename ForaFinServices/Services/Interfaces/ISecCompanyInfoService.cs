using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ISecCompanyInfoService
    {
        List<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter);

        Task CacheData(string cik);
    }
}
