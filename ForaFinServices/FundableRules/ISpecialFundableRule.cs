using ForaFinServices.Models;

namespace ForaFinServices.FundableRules
{
    public interface ISpecialFundableRule
    {
        decimal Apply(CompanyInfo companyInfo);
    }
}
