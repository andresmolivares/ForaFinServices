using ForaFinServices.Handlers.Messages;

namespace ForaFinServices.Services
{
    public class CacheRefreshService : BackgroundService
    {
        private const int MINUTE = 60000;
        private const string RELOAD_MINUTE_INTERVAL_KEY = "CacheRefreshSettings:RefreshIntervalInMinutes";
        private readonly int _interval;
        private readonly ILogger<CacheRefreshService> _logger;
        private readonly QueueService _queueService;
        
        public CacheRefreshService(IConfiguration configuration, ILogger<CacheRefreshService> logger, QueueService queueService)
        {
            _interval = (int.TryParse(configuration.GetSection(RELOAD_MINUTE_INTERVAL_KEY).Value, out var result) ? result : default) * MINUTE;
            _logger = logger;
            _queueService = queueService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if(_interval == default)
            {
                _logger.LogWarning("No valid {0} value was set: {1}", RELOAD_MINUTE_INTERVAL_KEY, _interval);
                await Task.CompletedTask;
            }

            while(!stoppingToken.IsCancellationRequested)
            {
                _logger.LogDebug("CacheRefreshService: Publishing LoadDataMessage");
                _queueService.PublishMessage(new LoadDataMessage());
                
                await Task.Delay(_interval);
            }

            await Task.CompletedTask;
        }
    }
}
