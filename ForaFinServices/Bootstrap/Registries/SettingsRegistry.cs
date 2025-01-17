using ForaFinServices.Settings;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class SettingsRegistry
    {
        public static IServiceCollection AddConfigSections(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .ConfigureSettings<SecApiSettings>(configuration.GetSection("SecApiSettings"))
                .ConfigureSettings<ParallelSettings>(configuration.GetSection("ParallelSettings"))
                .ConfigureSettings<BatchSettings>(configuration.GetSection("BatchSettings"))
                .ConfigureSettings<CacheRefreshSettings>(configuration.GetSection("CacheRefreshSettings"))
                .ConfigureSettings<CikSettings>(configuration.GetSection("CikSettings"))
                .ConfigureSettings<RetryPolicySettings>(configuration.GetSection("RetryPolicySettings"));

            return services;
        }

        public static IServiceCollection ConfigureSettings<TSettings>(this IServiceCollection services, IConfiguration configuration)
            where TSettings : class, new()
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            var config = new TSettings();
            configuration.Bind(config);
            services.AddSingleton(config);
            return services;
        }
    }
}
