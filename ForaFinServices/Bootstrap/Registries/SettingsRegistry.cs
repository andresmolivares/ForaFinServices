using ForaFinServices.Settings;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class SettingsRegistry
    {
        public static IServiceCollection AddConfigSections(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureSettings<SecApiSettings>(configuration.GetSection("SecApiSettings"));
            services.ConfigureSettings<ParallelSettings>(configuration.GetSection("ParallelSettings"));
            services.ConfigureSettings<BatchSettings>(configuration.GetSection("BatchSettings"));
            services.ConfigureSettings<CacheRefreshSettings>(configuration.GetSection("CacheRefreshSettings"));

            return services;
        }

        public static TSettings ConfigureSettings<TSettings>(this IServiceCollection services, IConfiguration configuration)
            where TSettings : class, new()
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            var config = new TSettings();
            configuration.Bind(config);
            services.AddSingleton(config);
            return config;
        }
    }
}
