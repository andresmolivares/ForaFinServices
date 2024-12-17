namespace ForaFinServices.Extensions
{
    using ForaFinServices.Constants;
    using ForaFinServices.Models;
    using System.Linq;

    public static class EdgarCompanyInfoExtensions
    {
        private static readonly char[] Vowels = ['a', 'e', 'i', 'o', 'u'];
        private static readonly Func<string, decimal> SpecialVowelRule = s => { return Vowels.ToList().Contains(s.ToLower().First()) ? SpecialVowelFundableRatio : 1m; };

        private const decimal SpecialVowelFundableRatio = .15m;
        private const decimal SpecialIncomeDiffFundableRatio = .25m;
        private const short Year2021 = 2021;
        private const short Year2022 = 2022;

        private const bool allowMultipleSpecialFunding = true;

        public static FundableAmountResponse ToFundableAmountResponse(this EdgarCompanyInfo owner)
        {
            var standardFundableAmount = owner.CalculateStandardFundableAmount();
            var specialFundableAmount = owner.CalculateSpecialFundableAmount(standardFundableAmount);
            return new FundableAmountResponse
            {
                Id = owner.Cik,
                Name = owner.EntityName,
                StandardFundableAmount = standardFundableAmount,
                SpecialFundableAmount = specialFundableAmount
            };
        }

        /// <summary>
        /// Returns the standard funbale amount based on it max recorded income between 2018 and 2022
        /// </summary>
        /// <requirements>
        /// Using highest income between 2018 and 2022:
        ///   If income is greater than or equal to $10B, standard fundable amount is 12.33% of income.
        ///   If income is less than $10B, standard fundable amount is 21.51% of income
        /// </requirements>
        private static decimal CalculateStandardFundableAmount(this EdgarCompanyInfo owner)
        {
            var standardFundableAmount = 0m;

            var units = owner.Facts?.UsGaap?.NetIncomeLoss?.Units;
            if (units == null)
                return standardFundableAmount;

            var usd10KOnly = units.GetUsd10KOnly();
            if (units!.HasStandardFundableAmounts() && usd10KOnly != null && usd10KOnly.Any())
            {
                var maxValue = usd10KOnly.Where(u => InfoFactUsGaapIncomeLossUnitsConstants.RequiredYears.Contains(u.GetYear())).Max(u => u.Val);
                return maxValue * (maxValue >= EdgarCompanyInfoConstants.FundableThreshold
                    ? EdgarCompanyInfoConstants.UpperStandardFundableRatio
                    : EdgarCompanyInfoConstants.LowerStandardFundableRatio);
            }
            return standardFundableAmount;
        }

        /// <summary>
        /// Returns the special fundable amount 
        /// </summary>
        /// <requirements>
        /// Initially, the Special Fundable Amount is the same as Standard Fundable Amount.
        ///   If the company name starts with a vowel, add 15% to the standard funding amount.
        ///   If the company’s 2022 income was less than their 2021 income, subtract 25% from their standard funding amount.
        /// </requirements>
        private static decimal CalculateSpecialFundableAmount(this EdgarCompanyInfo owner, decimal standardFundableAmount)
        {
            var units = owner.Facts?.UsGaap?.NetIncomeLoss?.Units;
            if (units == null)
                return default;

            var usd10KOnly = units.GetUsd10KOnly();
            if (units.HasStandardFundableAmounts() && usd10KOnly != null && usd10KOnly.Any())
            {
                var specialFundingAmount = owner.GetSpecialVowelAmount(standardFundableAmount);
                var finalAmount = owner.ApplySpecialIncomeDiffRule(specialFundingAmount);
                return finalAmount;
            }
            return default;
        }

        private static decimal GetSpecialVowelAmount(this EdgarCompanyInfo owner, decimal originalFundingAmount)
        {
            // calculate special vowel rule
            return allowMultipleSpecialFunding ? SpecialVowelRule(owner.EntityName) * originalFundingAmount : originalFundingAmount;
        }

        private static decimal ApplySpecialIncomeDiffRule(this EdgarCompanyInfo owner, decimal amount)
        {
            // special income diff between 2022 and 2021 rule
            var units = owner.Facts?.UsGaap?.NetIncomeLoss?.Units;
            if (units == null)
                return amount;

            var usd10KOnly = units.GetUsd10KOnly();
            if (usd10KOnly == null || !usd10KOnly.Any())
                return amount;

            var specialUsds = usd10KOnly.Where(u => InfoFactUsGaapIncomeLossUnitsConstants.IncomeYears.Contains(u.GetYear()));
            var usd2021 = specialUsds.First(u => u.GetYear() == Year2021);
            var usd2022 = specialUsds.First(u => u.GetYear() == Year2022);
            if (usd2022.Val < usd2021.Val)
            {
                amount -= amount * SpecialIncomeDiffFundableRatio;
            }

            return amount;
        }
    }
}
