using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoQueryService
    {
        IEnumerable<CompanyInfo> GetCompanyInfoList();
        CompanyInfo? GetCompanyInfo(long cikId);
        BaseFinancialResource? GetCompanyInfoResource(long cikId, string resourceType);
    }
}
