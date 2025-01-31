using ForaFinServices.Handlers.Messages;
using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace ForaFinServices.Services
{
    public class CompanyInfoCacheService : ICompanyInfoCacheService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly ILogger<CompanyInfoCacheService> _logger;
        private readonly IMemoryCache _cache;
        private readonly List<CompanyFilters> _cacheKeys = [];
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly MemoryCacheEntryOptions _cacheExpiration;
        private readonly IRetryPolicyService _retryPolicyService;
        private readonly ICompanyInfoPersistService _companyInfoPersistService;
        private readonly IServiceProvider _serviceProvider;

        public CompanyInfoCacheService(
            HttpClient httpClient,
            SecApiSettings _secApiSettings,
            ILogger<CompanyInfoCacheService> logger,
            IMemoryCache cache,
            IRetryPolicyService retryPolicyService,
            ICacheOptionsService cacheOptionsService,
            ICompanyInfoPersistService companyInfoPersistService,
            IServiceProvider serviceProvider)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("User-Agent", _secApiSettings.UserAgent);
            _httpClient.DefaultRequestHeaders.Add("Accept", _secApiSettings.Accept);
            _baseUrl = _secApiSettings.BaseUrl;
            _logger = logger;
            _cache = cache;
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            _cacheExpiration = cacheOptionsService.GetCacheOptions(CacheData);
            _retryPolicyService = retryPolicyService;
            _serviceProvider = serviceProvider;
            _companyInfoPersistService = companyInfoPersistService;
        }

        public async Task CacheData(string? cik)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(cik) || cik.Length != 10)
                {
                    throw new ArgumentException("CIK must be a 10-digit string, including leading zeros.");
                }

                if(!_cache.TryGetValue<CompanyInfo>(cik, out var companyInfo))
                {
                    var url = $"{_baseUrl}CIK{cik}.json";
                    var response = await _retryPolicyService.GetWithPolicy(() => _httpClient.GetAsync(url));
                    var jsonData = await response.Content.ReadAsStringAsync();
                    companyInfo = JsonSerializer.Deserialize<CompanyInfo>(jsonData, _serializerOptions)!;

                    try
                    {
                        StoreCacheData(cik, companyInfo);
                        var _queueService = _serviceProvider.GetRequiredService<QueueService>();
                        _queueService.PublishMessage(new PersistDataCommand { Data = jsonData, Key = cik });
                    }
                    catch(Exception e)
                    {
                        _logger.LogError("Cache error setting item {0}, {1}, error: {2}: ", companyInfo.EntityName, cik, e.Message);
                        throw;
                    }
                }
            }
            catch(HttpRequestException ex)
            {
                _logger.LogError("HTTP Error for CIK Id {0}: {1}", cik, ex.Message);
            }
            catch(JsonException ex)
            {
                _logger.LogError("JSON Error for CIK Id {0}: {1}", cik, ex.Message);
            }
            catch(Exception ex) 
            {
                _logger.LogError("Unhandled Error for CIK Id {0}: {1}", cik, ex.Message);
            }
        }

        private void StoreCacheData(string cik, CompanyInfo companyInfo)
        {
            if(companyInfo.EntityName is null)
                return;
            // Store data in the cache
            _cache.Set(cik, companyInfo, _cacheExpiration);
            _logger.LogDebug($"Loaded and cached: {companyInfo.EntityName}");
            lock(this)
            {
                if(!_cacheKeys.Any(key => key.CikId == cik))
                    _cacheKeys.Add(new CompanyFilters(companyInfo.EntityName, cik));
            }
        }

        public IEnumerable<CompanyInfo> GetCompanyInfo(string? letterFilter)
        {
            // Filter keys
            var filteredKeys = _cacheKeys
                .Where(key => string.IsNullOrWhiteSpace(letterFilter) || key.CompanyName.StartsWith(letterFilter!, StringComparison.OrdinalIgnoreCase));
            // Get cached data
            var cachedData = filteredKeys
                .Select(key => _cache.Get<CompanyInfo>(key.CikId)!);

            if(cachedData is not null && cachedData.Any())
            {
                return cachedData;
            }
            return _companyInfoPersistService.GetCompanyInfoList(filteredKeys.Select(key => key.CikId).ToArray());
        }

        public IEnumerable<CompanyInfo> GetCompanyInfoList()
        {
            // Get cached data
            var cachedData = _cacheKeys.Select(key => _cache.Get<CompanyInfo>(key.CikId)!);

            if(cachedData is not null && cachedData.Any())
            {
                return cachedData;
            }
            return _companyInfoPersistService.GetCompanyInfoList(_cacheKeys.Select(key => key.CikId).ToArray());
        }

        public CompanyInfo? GetCompanyInfoById(string cikId)
        {
            if(_cache.GetCurrentStatistics()?.CurrentEntryCount == 0)
                return null;

            var key = _cacheKeys.FirstOrDefault(key => !string.IsNullOrWhiteSpace(cikId) && key.CikId.EndsWith(cikId, StringComparison.OrdinalIgnoreCase));
            // Get cached data
            var cachedData = key is not null ? _cache.Get<CompanyInfo>(key.CikId) : null;

            if(cachedData is not null)
            {
                return cachedData;
            }
            return _companyInfoPersistService.GetCompanyInfoById(cikId);
        }
    }
}
