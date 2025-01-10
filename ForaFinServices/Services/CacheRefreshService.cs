using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Services
{
    public class CacheRefreshService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private const int MINUTE = 60000;
        private const string RELOAD_MINUTE_INTERVAL_KEY = "CacheRefreshSettings:RefreshIntervalInMinutes";
        private readonly int _interval;
        private readonly ILogger<CacheRefreshService> _logger;

        public CacheRefreshService(IServiceProvider serviceProvider, IConfiguration configuration, ILogger<CacheRefreshService> logger)
        {
            _serviceProvider = serviceProvider;
            _interval = (int.TryParse(configuration.GetSection(RELOAD_MINUTE_INTERVAL_KEY).Value, out var result) ? result : default) * MINUTE;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if(_interval == default)
            {
                _logger.LogWarning("No valid {0} value was set: {1}", RELOAD_MINUTE_INTERVAL_KEY, _interval);
                await Task.CompletedTask;
            }

            using(var scope = _serviceProvider.CreateScope())
            {
                var service = _serviceProvider.GetService<IFundableAmountService>();

                while(!stoppingToken.IsCancellationRequested)
                {
                    if(service != null)
                        await service.PersistData();

                    await Task.Delay(_interval);
                }
            }

            await Task.CompletedTask;
        }
    }
}
