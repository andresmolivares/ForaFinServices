namespace ForaFinServices.Extensions
{
    using ForaFinServices.Constants;
    using ForaFinServices.Models;
    using System.Linq;

    public static class FinancialUnitExtensions
    {
        public static IEnumerable<FinancialUnit>? GetUsd10KOnly(this Units owner)
        {
            return owner?.USD?.Where(u => u.Form == AppConstants.FormKey);
        }

        public static bool ValidatePositiveUsdValueByYear(this IEnumerable<FinancialUnit>? owner, short year)
        {
            if(owner is null || !owner.Any()) 
                return false;
            return owner
                .FirstOrDefault(usd => AppConstants.IncomeYears.Contains(usd.GetYear()))?
                .Val > 0;
        }

        public static short GetYear(this FinancialUnit owner)
        {
            return short.TryParse(owner.Frame?.Replace("CY", string.Empty), out var result) ? result : (short)0;
        }
    }
}
