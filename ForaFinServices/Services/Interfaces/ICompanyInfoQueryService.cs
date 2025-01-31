using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoQueryService
    {
        IEnumerable<CompanyInfo> GetCompanyInfoList();
        CompanyInfo? GetCompanyInfo(long cikId);
        FinancialResource? GetCompanyInfoResource(long cikId, string resourceType);
    }
}
