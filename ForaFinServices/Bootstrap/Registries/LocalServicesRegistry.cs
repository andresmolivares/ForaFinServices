using ForaFinServices.Services;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class LocalServicesRegistry
    {
        public static IServiceCollection AddLocalServices(this IServiceCollection services)
        {
            services.AddTransient<IFundableAmountService, FundableAmountService>();
            services.AddTransient<ICikDataService, CikDataService>();
            services.AddSingleton<ICompanyInfoCacheService, CompanyInfoCacheService>();
            services.AddHttpClient<CompanyInfoCacheService>();

            return services;
        }
    }
}
