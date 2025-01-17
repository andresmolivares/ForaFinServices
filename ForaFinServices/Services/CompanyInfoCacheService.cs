using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace ForaFinServices.Services
{
    public record CompanyFilters(string CompanyName, string CikId, string CacheKey);

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

        public CompanyInfoCacheService(
            HttpClient httpClient,
            SecApiSettings _secApiSettings,
            ILogger<CompanyInfoCacheService> logger,
            IMemoryCache cache,
            IRetryPolicyService retryPolicyService,
            ICacheOptionsService cacheOptionsService)
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
        }

        public async Task CacheData(string? cik)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(cik) || cik.Length != 10)
                {
                    throw new ArgumentException("CIK must be a 10-digit string, including leading zeros.");
                }

                string cacheKey = $"CompanyInfo_{cik}";

                if(!_cache.TryGetValue<EdgarCompanyInfo>(cacheKey, out var companyInfo))
                {
                    var url = $"{_baseUrl}CIK{cik}.json";
                    var response = await _retryPolicyService.GetWithPolicy(() => _httpClient.GetAsync(url));
                    var jsonData = await response.Content.ReadAsStringAsync();
                    companyInfo = JsonSerializer.Deserialize<EdgarCompanyInfo>(jsonData, _serializerOptions)!;

                    try
                    {
                        StoreCacheData(cik, cacheKey, companyInfo);
                    }
                    catch(Exception e)
                    {
                        _logger.LogError("Cache error setting item {0}, {1}, {2}, error: {3}: ", companyInfo.EntityName, cik, cacheKey, e.Message);
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

        private void StoreCacheData(string cik, string cacheKey, EdgarCompanyInfo companyInfo)
        {
            // Store data in the cache
            _cache.Set(cacheKey, companyInfo, _cacheExpiration);
            _logger.LogDebug($"Loaded and cached: {companyInfo.EntityName}");
            lock(this)
            {
                if(!_cacheKeys.Any(key => key.CacheKey == cacheKey))
                    _cacheKeys.Add(new CompanyFilters(companyInfo.EntityName, cik, cacheKey));
            }
        }

        public IEnumerable<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter)
        {
            return _cache.GetCurrentStatistics()?.CurrentEntryCount == 0
                ? Array.Empty<EdgarCompanyInfo>()
                : _cacheKeys
                .Where(key => string.IsNullOrWhiteSpace(letterFilter) || key.CompanyName.StartsWith(letterFilter!, StringComparison.OrdinalIgnoreCase))
                .Select(key => _cache.Get<EdgarCompanyInfo>(key.CacheKey)!);
        }

        public IEnumerable<EdgarCompanyInfo> GetCompanyInfoList()
        {
            return _cache.GetCurrentStatistics()?.CurrentEntryCount == 0
                ? Array.Empty<EdgarCompanyInfo>()
                : _cacheKeys.Select(key => _cache.Get<EdgarCompanyInfo>(key.CacheKey)!);
        }

        public EdgarCompanyInfo? GetCompanyInfoById(string cikId)
        {
            if(_cache.GetCurrentStatistics()?.CurrentEntryCount == 0)
                return null;

            var key = _cacheKeys.FirstOrDefault(key => !string.IsNullOrWhiteSpace(cikId) && key.CikId.EndsWith(cikId, StringComparison.OrdinalIgnoreCase));
            return key is null ? null : _cache.Get<EdgarCompanyInfo>(key.CacheKey);
        }
    }
}
