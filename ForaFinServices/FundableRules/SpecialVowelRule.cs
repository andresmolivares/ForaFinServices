namespace ForaFinServices.FundableRules
{
    using ForaFinServices.Constants;
    using ForaFinServices.Extensions;
    using ForaFinServices.Models;
    using System.Linq;

    public class SpecialVowelRule : ISpecialFundableRule
    {
        public decimal Apply(CompanyInfo companyInfo)
        {
            var amount = companyInfo.CalculateStandardFundableAmount();
            // calculate special vowel rule
            return AppConstants.Vowels.ToList().Contains(companyInfo.EntityName.ToLower().First())
                ? amount * AppConstants.SpecialVowelFundableRatio
                : 0;
        }
    }
}
