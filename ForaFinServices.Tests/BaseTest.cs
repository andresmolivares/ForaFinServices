using Bogus;
using ForaFinServices.Constants;
using ForaFinServices.Models;


namespace ForaFinServices.Tests
{
    public class BaseTest
    {
        protected const long Amount15B = 15_000_000_000;
        protected const long Amount8B = 8_000_000_000;
        protected const long NegativeAmount = -5_000_000_000;
        protected const string VowelStartCompanyName = "ABC Store";


        protected EdgarCompanyInfo BuildCompanyInfoMock(
            decimal maxAmount = AppConstants.FundableThreshold,
            string companyName = "Sample Company",
            bool withDecreasingUsdValue = false
            )
        {
            var years = AppConstants.RequiredYears.Select(s => $"CY{s}");
            var yearsIndex = 0;

            var usdMock = new Faker<USD>()
                .RuleFor(f => f.Form, "10-K")
                .RuleFor(f => f.Frame, v =>
                {
                    if (yearsIndex >= years.Count())
                        yearsIndex = 0;
                    return years.ElementAt(yearsIndex++);
                })
                .RuleFor(f => f.Val, v =>
                {
                    var threshold = yearsIndex / 100m;
                    var subsequentAmount = withDecreasingUsdValue 
                        ? maxAmount - (maxAmount * threshold) 
                        : maxAmount;
                    return yearsIndex <= 1 ? maxAmount : subsequentAmount;
                });

            var unitsMock = new Faker<Units>().RuleFor(f => f.USD, v => usdMock.Generate(7));
            var netIncomeLossMock = new Faker<NetIncomeLoss>().RuleFor(f => f.Units, v => unitsMock);
            var usGaapMock = new Faker<UsGaap>().RuleFor(f => f.NetIncomeLoss, v => netIncomeLossMock);
            var factsMock = new Faker<Facts>().RuleFor(f => f.UsGaap, v => usGaapMock);
            
            var companyInfoMock = new Faker<EdgarCompanyInfo>()
                .RuleFor(ci => ci.Cik, v => $"{v.Random.Number(1234, 9999999)}".PadLeft(10, '0'))
                .RuleFor(ci => ci.EntityName, companyName)
                .RuleFor(ci => ci.Facts, v => factsMock);

            return companyInfoMock.Generate();
        }
    }
}