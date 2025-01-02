using ForaFinServices.Models;

namespace ForaFinServices.Extensions
{
    public static class UsdExtensions
    {
        public static short GetYear(this USD owner)
        {
            return short.TryParse(owner.Frame?.Replace("CY", string.Empty), out var result) ? result : (short)0;
        }
    }
}
