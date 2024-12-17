using ForaFinServices.Services;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class LocalServicesExtensions
    {
        public static IServiceCollection AddLocalServices(this IServiceCollection services)
        {
            services.AddTransient<IFundableAmountService, FundableAmountService>();
            services.AddTransient<ICikRepositoryService, CikRepositoryService>();
            services.AddSingleton<ISecCompanyInfoService, SecCompanyInfoService>();
            services.AddHttpClient<SecCompanyInfoService>();

            return services;
        }
    }
}
