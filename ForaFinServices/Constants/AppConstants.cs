namespace ForaFinServices.Constants
{
    public static class AppConstants
    {
        public const string FormKey = "10-K";
        public const decimal LowerSpecialFundableRatio = .25m;
        public static short[] IncomeYears = [2021, 2022];
        public static short[] RequiredYears = [2018, 2019, 2020, 2021, 2022];

        public const decimal FundableThreshold = 10_000_000_000;
        public const decimal GreaterThan10BStandardFundableRatio = .1233m;
        public const decimal LesserThan10BStandardFundableRatio = .2151m;

        public const decimal SpecialVowelFundableRatio = .15m;
        public const decimal SpecialIncomeDiffFundableRatio = .25m;
        public const short Year2021 = 2021;
        public const short Year2022 = 2022;

        public static readonly char[] Vowels = ['a', 'e', 'i', 'o', 'u'];
    }
}
