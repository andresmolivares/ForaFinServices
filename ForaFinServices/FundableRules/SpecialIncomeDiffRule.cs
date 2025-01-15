using ForaFinServices.Extensions;

namespace ForaFinServices.FundableRules
{
    using ForaFinServices.Constants;
    using ForaFinServices.Models;
    using System;
    using System.Linq;

    public class SpecialIncomeDiffRule : ISpecialFundableRule
    {
        public decimal Apply(CompanyInfo companyInfo)
        {
            var _usd10KOnly = companyInfo.Facts?.UsGaap?.NetIncomeLoss?.Units?.GetUsd10KOnly();
            if(_usd10KOnly is null)
                return default;

            var amount = companyInfo.CalculateStandardFundableAmount();

            var specialUsds = _usd10KOnly!.Where(u => AppConstants.IncomeYears.Contains(u.GetYear()));
            var usd2021 = specialUsds.First(u => u.GetYear() == AppConstants.Year2021);
            var usd2022 = specialUsds.First(u => u.GetYear() == AppConstants.Year2022);
            if(usd2022.Val < usd2021.Val)
            {
                return amount * AppConstants.SpecialIncomeDiffFundableRatio * -1;
            }

            return default;
        }
    }
}
