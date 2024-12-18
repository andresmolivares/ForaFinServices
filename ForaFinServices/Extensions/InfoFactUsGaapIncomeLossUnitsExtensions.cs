namespace ForaFinServices.Extensions
{
    using ForaFinServices.Constants;
    using ForaFinServices.Models;
    using System.Linq;

    public static class InfoFactUsGaapIncomeLossUnitsExtensions
    {
        /// <summary>
        /// Determines whether the Usd collections contain valid Standard Fundable Amount requisites
        /// </summary>
        /// <requirements>
        /// Company must have income data for all years between (and including) 2018 and 2022. If they did not, their Standard Fundable Amount is $0.
        /// Company must have had positive income in both 2021 and 2022. If they did not, their Standard Fundable Amount is $0.
        /// </requirements>
        public static bool HasStandardFundableAmounts(this InfoFactUsGaapIncomeLossUnits owner)
        {
            var usd10KOnly = owner.GetUsd10KOnly();
            return usd10KOnly != null
                && usd10KOnly.Any()
                && AppConstants.RequiredYears.All(year => usd10KOnly.Select(y => y.GetYear()).Contains(year))
                && ValidatePositiveIncome(usd10KOnly.First(u => u.GetYear() == 2021))
                && ValidatePositiveIncome(usd10KOnly.First(u => u.GetYear() == 2022));
        }

        public static IEnumerable<InfoFactUsGaapIncomeLossUnitsUsd>? GetUsd10KOnly(this InfoFactUsGaapIncomeLossUnits owner)
        {
            return owner.Usd?.Where(u => u.Form == AppConstants.FormKey);
        }

        private static bool ValidatePositiveIncome(InfoFactUsGaapIncomeLossUnitsUsd usd)
        {
            return AppConstants.IncomeYears.Contains(usd.GetYear()) && usd.Val > 0;
        }
    }
}
