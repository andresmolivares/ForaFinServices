using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace ForaFinServices.Services
{
    public record CompanyFilters(string CompanyName, string CacheKey);

    public class CompanyInfoCacheService: ICompanyInfoCacheService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly ILogger<CompanyInfoCacheService> _logger;
        private readonly IMemoryCache _cache;
        private readonly List<CompanyFilters> _cacheKeys = [];
        private readonly JsonSerializerOptions _serializerOptions;

        public CompanyInfoCacheService(
            HttpClient httpClient, 
            SecApiSettings _secApiSettings,
            ILogger<CompanyInfoCacheService> logger,
            IMemoryCache cache)
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
        }

        public async Task CacheData(string cik)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cik) || cik.Length != 10)
                {
                    throw new ArgumentException("CIK must be a 10-digit string, including leading zeros.");
                }

                string cacheKey = $"CompanyInfo_{cik}";

                if (!_cache.TryGetValue<EdgarCompanyInfo>(cacheKey, out var companyInfo))
                {
                    var url = $"{_baseUrl}CIK{cik}.json";
                    var response = await _httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var jsonData = await response.Content.ReadAsStringAsync();
                    companyInfo = JsonSerializer.Deserialize<EdgarCompanyInfo>(jsonData, _serializerOptions);

                    if (companyInfo != null)
                    {
                        // Store data in the cache
                        _cache.Set(cacheKey, companyInfo, TimeSpan.FromMinutes(10));
                        _logger.LogDebug($"Loaded and cached: {companyInfo.EntityName}");
                        _cacheKeys.Add(new CompanyFilters(companyInfo.EntityName, cacheKey));
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError("HTTP Error for CIK Id {0}: {1}", cik, ex.Message);
                throw;
            }
            catch (JsonException ex)
            {
                _logger.LogError("JSON Error for CIK Id {0}: {1}", cik, ex.Message);
                throw;
            }

        }

        public IEnumerable<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter)
        {
            return _cacheKeys
                .Where(key => string.IsNullOrWhiteSpace(letterFilter) || key.CompanyName.StartsWith(letterFilter!, StringComparison.OrdinalIgnoreCase))
                .Select(key => _cache.Get<EdgarCompanyInfo>(key.CacheKey)!);
          
        }

        public IEnumerable<EdgarCompanyInfo> GetCompanyInfoList()
        {
            return _cacheKeys
                .Select(key => _cache.Get<EdgarCompanyInfo>(key.CacheKey)!);

        }
    }
}
