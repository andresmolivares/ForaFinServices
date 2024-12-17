using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace ForaFinServices.Services
{
    public class SecCompanyInfoService: ISecCompanyInfoService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly ILogger<SecCompanyInfoService> _logger;
        private readonly IMemoryCache _cache;
        private readonly List<string> _cacheKeys = [];
        private readonly JsonSerializerOptions _serializerOptions;

        public SecCompanyInfoService(
            HttpClient httpClient, 
            SecApiSettings _secApiSettings,
            ILogger<SecCompanyInfoService> logger,
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
                        _logger.LogInformation($"Loaded and cached: {companyInfo.EntityName}");
                        _cacheKeys.Add(cacheKey);
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

        public List<EdgarCompanyInfo> GetCompanyInfo(string? letterFilter)
        {
            var results = new List<EdgarCompanyInfo>();
            var isLetterFilterEmpty = string.IsNullOrWhiteSpace(letterFilter);
            
            foreach (var cacheKey in _cacheKeys)
            {
                if (_cache.TryGetValue<EdgarCompanyInfo>(cacheKey, out var companyInfo) && companyInfo!.EntityName != null)
                {
                    if (!isLetterFilterEmpty && !companyInfo.EntityName.StartsWith(letterFilter!, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    results.Add(companyInfo);
                }
            }

            return results;
        }
    }
}
