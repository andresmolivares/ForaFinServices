namespace ForaFinServices.Extensions
{
    using ForaFinServices.Constants;
    using ForaFinServices.Models;
    using System.Linq;

    public static class UnitsExtensions
    {
        public static IEnumerable<USD>? GetUsd10KOnly(this Units owner)
        {
            return owner is null ? null : owner.USD?.Where(u => u.Form == AppConstants.FormKey);
        }

        public static bool ValidatePositiveUsdValueByYear(this IEnumerable<USD>? owner, short year)
        {
            if(owner is null || !owner.Any()) 
                return false;
            return owner
                .FirstOrDefault(usd => AppConstants.IncomeYears.Contains(usd.GetYear()))?
                .Val > 0;
        }
    }
}
