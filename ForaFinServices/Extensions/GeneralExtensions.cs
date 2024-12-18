namespace ForaFinServices.Extensions
{
    using System;

    public static class GeneralExtensions
    {
        public static decimal WithPrecision(this decimal owner, int precision = 2)
        {
            return Math.Round(owner, precision);
        }
    }
}
