using FluentAssertions;
using ForaFinServices.Constants;
using ForaFinServices.Extensions;


namespace ForaFinServices.Tests
{
    public class FundableAmountCalculationTests : BaseTest
    {
        [TestCase()]
        public void when_standard_fundable_income_is_eligible()
        {
            var companyInfoMock = BuildCompanyInfoMock();

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.StandardFundableAmount.Should().BeGreaterThan(0);
            actual.SpecialFundableAmount.Should().BeGreaterThan(0);
        }

        [TestCase(NegativeAmount)]
        public void when_standard_fundable_income_is_ineligible(long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(maxAmount: amount);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.StandardFundableAmount.Should().Be(0);
            actual.SpecialFundableAmount.Should().Be(0);
        }

        [TestCase(Amount15B)]
        public void when_standard_fundable_income_is_ge_10B(long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(maxAmount: amount);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.StandardFundableAmount.Should().BeGreaterThan(0);
            actual.StandardFundableAmount.Should().Be(amount * AppConstants.GreaterThan10BStandardFundableRatio);
        }

        [TestCase(Amount8B)]
        public void when_standard_fundable_income_is_le_10B(long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(maxAmount: amount);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.StandardFundableAmount.Should().BeGreaterThan(0);
            actual.StandardFundableAmount.Should().Be(amount * AppConstants.LesserThan10BStandardFundableRatio);
        }

        [TestCase(Amount15B)]
        public void when_standard_fundable_income_is_ge_10B_and_2022_income_lt_2021_income(long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(maxAmount: amount, withDecreasingUsdValue: true);
            var sfa = amount * AppConstants.GreaterThan10BStandardFundableRatio;
            var expected = sfa - (sfa * AppConstants.SpecialIncomeDiffFundableRatio);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.SpecialFundableAmount.Should().Be(expected);
        }


        [TestCase(Amount8B)]
        public void when_standard_fundable_income_is_le_10B_and_2022_income_lt_2021_income(long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(maxAmount: amount, withDecreasingUsdValue: true);
            var sfa = amount * AppConstants.LesserThan10BStandardFundableRatio;
            var expected = sfa - (sfa * AppConstants.SpecialIncomeDiffFundableRatio);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.SpecialFundableAmount.Should().Be(expected);
        }

        [TestCase(VowelStartCompanyName, Amount15B)]
        public void when_standard_fundable_income_is_ge_10B_and_company_name_start_with_vowel(string companyName, long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(companyName: companyName, maxAmount: amount);
            var sfa = amount * AppConstants.GreaterThan10BStandardFundableRatio;
            var expected = sfa + (sfa * AppConstants.SpecialVowelFundableRatio);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.SpecialFundableAmount.Should().Be(expected);
        }

        [TestCase(VowelStartCompanyName, Amount8B)]
        public void when_standard_fundable_income_is_le_10B_and_company_name_start_with_vowel(string companyName, long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(companyName: companyName, maxAmount: amount);
            var sfa = amount * AppConstants.LesserThan10BStandardFundableRatio;
            var expected = sfa + (sfa * AppConstants.SpecialVowelFundableRatio);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.SpecialFundableAmount.Should().Be(expected);
        }

        [TestCase(VowelStartCompanyName, Amount15B)]
        public void when_standard_fundable_income_is_ge_10B_and_company_name_start_with_vowel_and_2022_income_lt_2021_income(string companyName, long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(companyName: companyName, maxAmount: amount, withDecreasingUsdValue: true);
            var sfa = amount * AppConstants.GreaterThan10BStandardFundableRatio;
            var expected = sfa
                + (sfa * AppConstants.SpecialVowelFundableRatio)
                - (sfa * AppConstants.SpecialIncomeDiffFundableRatio);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.SpecialFundableAmount.Should().Be(expected);
        }

        [TestCase(VowelStartCompanyName, Amount8B)]
        public void when_standard_fundable_income_is_le_10B_and_company_name_start_with_vowel_and_2022_income_lt_2021_income(string companyName, long amount)
        {
            var companyInfoMock = BuildCompanyInfoMock(companyName: companyName, maxAmount: amount, withDecreasingUsdValue: true);
            var sfa = amount * AppConstants.LesserThan10BStandardFundableRatio;
            var expected = sfa
                + (sfa * AppConstants.SpecialVowelFundableRatio)
                - (sfa * AppConstants.SpecialIncomeDiffFundableRatio);

            var actual = companyInfoMock.MapToFundableAmountResponse();

            actual.Should().NotBeNull();
            actual.SpecialFundableAmount.Should().Be(expected);
        }
    }
}