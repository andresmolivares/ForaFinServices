using ForaFinServices.Handlers;

namespace ForaFinServices.Bootstrap.Registries
{
    public static class HandlersRegistry
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            return services
                .AddTransient<IMessageHandler, LoadDataHandler>()
                .AddTransient<IMessageHandler, CacheBatchDataHandler>();
        }
    }
}
