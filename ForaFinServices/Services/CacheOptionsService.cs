using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using Microsoft.Extensions.Caching.Memory;

namespace ForaFinServices.Services
{
    public class CacheOptionsService : ICacheOptionsService
    {
        private readonly CacheRefreshSettings _cacheRefreshSettings;

        public CacheOptionsService(CacheRefreshSettings cacheRefreshSettings)
        {
            _cacheRefreshSettings = cacheRefreshSettings;
        }

        public MemoryCacheEntryOptions GetCacheOptions(Func<string?, Task> executeEvictCallback) => new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(_cacheRefreshSettings.AbsoluteExpirationInMinutes),
            SlidingExpiration = TimeSpan.FromMinutes(_cacheRefreshSettings.SlidingExpirationInMinutes),
            PostEvictionCallbacks =
                    {
                        new PostEvictionCallbackRegistration
                        {
                            EvictionCallback = (key, value, reason, state) =>
                            {
                                Console.WriteLine($"Cache item '{key}' was evicted due to {reason}.");
                                var cikKey = key?.ToString()?.Replace("CompanyInfo_", "");
                                Task.Run(async () => await executeEvictCallback(cikKey));
                            }
                        }
                    }
        };
    }

}



