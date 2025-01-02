using ForaFinServices.DTO;

namespace ForaFinServices.Services.Interfaces
{
    public interface IFundableAmountService
    {
        Task PersistData();
        IEnumerable<FundableAmountDto> GetFundableAmount(string? letterFilter);
    }

    public interface ICompanyInfoCommandService
    {
        Task Delete ();
    }
}
