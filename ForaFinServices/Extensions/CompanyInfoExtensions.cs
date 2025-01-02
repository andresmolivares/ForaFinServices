namespace ForaFinServices.Extensions
{
    using AutoMapper;
    using ForaFinServices.Constants;
    using ForaFinServices.DTO;
    using ForaFinServices.Models;
    using System;
    using System.Linq;

    public static class CompanyInfoExtensions
    {
        /// <summary>
        /// Maps to a <see cref="FundableAmountDto"/>
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static FundableAmountDto MapToFundableAmount(this CompanyInfo owner)
        {
            var standardFundableAmount = owner.CalculateStandardFundableAmount();
            var specialFundableAmount = owner.CalculateSpecialFundableAmount(standardFundableAmount);
            return new FundableAmountDto
            {
                Id = owner.Cik,
                Name = owner.EntityName,
                StandardFundableAmount = standardFundableAmount.WithPrecision(),
                SpecialFundableAmount = specialFundableAmount.WithPrecision()
            };
        }

        /// <summary>
        /// Returns the standard fundable amount based on it max recorded income between 2018 and 2022
        /// </summary>
        /// <requirements>
        /// Using highest income between 2018 and 2022:
        ///   If income is greater than or equal to $10B, standard fundable amount is 12.33% of income.
        ///   If income is less than $10B, standard fundable amount is 21.51% of income
        /// </requirements>
        private static decimal CalculateStandardFundableAmount(this CompanyInfo owner)
        {
            var standardFundableAmount = 0m;

            var units = owner.Facts?.UsGaap?.NetIncomeLoss?.Units;
            if (units == null)
                return standardFundableAmount;

            var usd10KOnly = units.GetUsd10KOnly();
            if (units!.HasStandardFundableAmounts() && usd10KOnly != null && usd10KOnly.Any())
            {
                var maxValue = usd10KOnly.Where(u => AppConstants.RequiredYears.Contains(u.GetYear())).Max(u => u.Val);
                return maxValue * (maxValue >= AppConstants.FundableThreshold
                    ? AppConstants.GreaterThan10BStandardFundableRatio
                    : AppConstants.LesserThan10BStandardFundableRatio);
            }
            return standardFundableAmount;
        }

        /// <summary>
        /// Returns the special fundable amount based on company name and income values between 2021 and 2022
        /// </summary>
        /// <requirements>
        /// Initially, the Special Fundable Amount is the same as Standard Fundable Amount.
        ///   If the company name starts with a vowel, add 15% to the standard funding amount.
        ///   If the company’s 2022 income was less than their 2021 income, subtract 25% from their standard funding amount.
        /// </requirements>
        private static decimal CalculateSpecialFundableAmount(this CompanyInfo owner, decimal standardFundableAmount)
        {
            var units = owner.Facts?.UsGaap?.NetIncomeLoss?.Units;
            if (units == null)
                return default;

            var usd10KOnly = units.GetUsd10KOnly();
            if (usd10KOnly == null || !usd10KOnly.Any())
                return default;

            if (units.HasStandardFundableAmounts() && usd10KOnly != null && usd10KOnly.Any())
            {
                var specialVowelAmount = owner.GetSpecialVowelAmount(standardFundableAmount);
                var specialIncomeDiffRule = owner.GetSpecialIncomeDiffRule(standardFundableAmount);
                return standardFundableAmount + specialVowelAmount - specialIncomeDiffRule;
            }
            return default;
        }

        private static decimal GetSpecialVowelAmount(this CompanyInfo owner, decimal amount)
        {
            // calculate special vowel rule
            return AppConstants.Vowels.ToList().Contains(owner.EntityName.ToLower().First()) 
                ? amount * AppConstants.SpecialVowelFundableRatio
                : 0;
        }

        private static decimal GetSpecialIncomeDiffRule(this CompanyInfo owner, decimal amount)
        {
            // special income diff between 2022 and 2021 rule
            var units = owner.Facts?.UsGaap?.NetIncomeLoss?.Units;
            var usd10KOnly = units!.GetUsd10KOnly();
            var specialUsds = usd10KOnly!.Where(u => AppConstants.IncomeYears.Contains(u.GetYear()));
            var usd2021 = specialUsds.First(u => u.GetYear() == AppConstants.Year2021);
            var usd2022 = specialUsds.First(u => u.GetYear() == AppConstants.Year2022);
            if (usd2022.Val < usd2021.Val)
            {
                return amount * AppConstants.SpecialIncomeDiffFundableRatio;
            }

            return default;
        }

        public static BaseFinancialResource? GetFinancialResource(this CompanyInfo owner, string resourceType) => resourceType switch
        {
            "EntityCommonStockSharesOutstanding" => owner.Facts.Dei.EntityCommonStockSharesOutstanding,
            "EntityNumberOfEmployees" => owner.Facts.Dei.EntityNumberOfEmployees,
            "EntityPublicFloat" => owner.Facts.Dei.EntityPublicFloat,
            "NetIncomeLoss" => owner.Facts.UsGaap.NetIncomeLoss,
            _ => null,
        };
    }


    public static class Mapper
    {
        public static CompanyInfoDto MapToDto(this IMapper owner, CompanyInfo companyInfo)
        {
            return owner.Map<CompanyInfoDto>(companyInfo);
        }


    }
}
