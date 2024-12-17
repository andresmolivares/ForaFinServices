using ForaFinServices.Models;

namespace ForaFinServices.Extensions
{
    public static class InfoFactUsGaapIncomeLossUnitsUsdExtensions
    {
        public static short GetYear(this InfoFactUsGaapIncomeLossUnitsUsd owner)
        {
            return short.TryParse(owner.Frame?.Replace("CY", string.Empty), out var result) ? result : (short)0;
        }
    }
}
