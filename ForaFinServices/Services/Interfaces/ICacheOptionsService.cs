using Microsoft.Extensions.Caching.Memory;

namespace ForaFinServices.Services.Interfaces;

public interface ICacheOptionsService
{
    MemoryCacheEntryOptions GetCacheOptions(Func<string?, Task> executeEvictCallback);
}