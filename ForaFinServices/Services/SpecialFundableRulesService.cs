using ForaFinServices.FundableRules;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Services
{
    public class SpecialFundableRulesService : ISpecialFundableRulesService
    {
        private readonly IEnumerable<ISpecialFundableRule> _specialFundableRules;

        public SpecialFundableRulesService(IEnumerable<ISpecialFundableRule> specialFundableRules) 
        {
            _specialFundableRules = specialFundableRules;
        }

        public IEnumerable<ISpecialFundableRule> GetSpecialFundableRules()
        {
            return _specialFundableRules;
        }
    }
}
