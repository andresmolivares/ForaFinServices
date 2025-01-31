using ForaFinServices.Handlers.Messages;
using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface ICompanyInfoPersistService
    {
        Task PersistData(PersistDataCommand message);

        IEnumerable<CompanyInfo> GetCompanyInfoList(string[] cikIds);

        CompanyInfo? GetCompanyInfoById(string cikId);
    }
}
