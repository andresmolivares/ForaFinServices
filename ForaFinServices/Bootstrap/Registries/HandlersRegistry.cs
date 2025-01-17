using ForaFinServices.Handlers;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class HandlersRegistry
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services
                .AddTransient<IMessageHandler, LoadDataHandler>()
                .AddTransient<IMessageHandler, CacheBatchDataHandler>();

            return services;
        }
    }
}
