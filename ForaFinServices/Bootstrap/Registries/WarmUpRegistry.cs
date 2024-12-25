using ForaFinServices.Services;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class WarmUpRegistry
    {
        private const string ENABLE_WARM_UP_KEY = "WarmUpSettings:EnableWarmUp";

        public static IServiceCollection AddWarmUpBehavior(this IServiceCollection services, IConfiguration configuration)
        {
            bool.TryParse(configuration.GetSection(ENABLE_WARM_UP_KEY).Value, out var enableWarmUp);

            if (enableWarmUp)
            {
                services.AddHostedService<WarmUpService>();
            }

            return services;
        }
    }
}
