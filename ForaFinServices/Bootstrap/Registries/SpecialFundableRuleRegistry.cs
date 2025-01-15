using ForaFinServices.FundableRules;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class SpecialFundableRuleRegistry
    {
        public static IServiceCollection AddSpecialFundableRules(this IServiceCollection services)
        {
            return services
                .AddTransient<ISpecialFundableRule, SpecialVowelRule>()
                .AddTransient<ISpecialFundableRule, SpecialIncomeDiffRule>();
        }
    }
}
