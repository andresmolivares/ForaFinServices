using ForaFinServices.FundableRules;

namespace ForaFinServices.Services.Interfaces
{
    public interface ISpecialFundableRulesService
    {
        IEnumerable<ISpecialFundableRule> GetSpecialFundableRules();
    }
}
