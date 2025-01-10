using ForaFinServices.Services;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class CacheRefreshRegistry
    {
        public static IServiceCollection AddCacheRefreshBehavior(this IServiceCollection services)
        {
            services.AddHostedService<CacheRefreshService>();

            return services;
        }
    }
}
