using ForaFinServices.Services;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class LocalServicesRegistry
    {
        public static IServiceCollection AddLocalServices(this IServiceCollection services)
        {
            services
                .AddSingleton<QueueService>()
                .AddTransient<IFundableAmountService, FundableAmountService>()
                .AddTransient<ICikDataService, CikDataService>()
                .AddTransient<IRetryPolicyService, RetryPolicyService>()
                .AddTransient<ICacheOptionsService, CacheOptionsService>()
                .AddSingleton<ICompanyInfoCacheService, CompanyInfoCacheService>()
                .AddTransient<ICompanyInfoQueryService, CompanyInfoQueryService>()
                .AddHttpClient<CompanyInfoCacheService>();

            return services;
        }
    }
}
