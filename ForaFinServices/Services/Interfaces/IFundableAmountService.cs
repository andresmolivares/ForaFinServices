using ForaFinServices.Models;

namespace ForaFinServices.Services.Interfaces
{
    public interface IFundableAmountService
    {
        Task PersistData();

        IEnumerable<FundableAmountResponse> GetFundableAmount(string letterFilter);
    }
}
