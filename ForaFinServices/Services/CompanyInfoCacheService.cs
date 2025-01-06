﻿using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace ForaFinServices.Services
{
    public record CompanyFilters(string CompanyName, string CikId, string CacheKey);

    public class CompanyInfoCacheService: ICompanyInfoCacheService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        private readonly ILogger<CompanyInfoCacheService> _logger;
        private readonly IMemoryCache _cache;
        private readonly List<CompanyFilters> _cacheKeys = [];
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly CacheRefreshSettings _cacheRefreshSettings;
        private readonly MemoryCacheEntryOptions _cacheExpiration;

        public CompanyInfoCacheService(
            HttpClient httpClient, 
            SecApiSettings _secApiSettings,
            ILogger<CompanyInfoCacheService> logger,
            IMemoryCache cache,
            CacheRefreshSettings cacheRefreshSettings)
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
            _cacheRefreshSettings = cacheRefreshSettings;
            _cacheExpiration = GetCacheOptions();
        }

        private MemoryCacheEntryOptions GetCacheOptions()
        {
            return new MemoryCacheEntryOptions
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
                                var cikKey = key.ToString().Replace("CompanyInfo_", "");
                                Task.Run(async () => await CacheData(cikKey));
                            }
                        }
                    }
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

                    try
                    {
                        var jsonData = await response.Content.ReadAsStringAsync();
                        companyInfo = JsonSerializer.Deserialize<EdgarCompanyInfo>(jsonData, _serializerOptions)!;
                        // Store data in the cache
                        _cache.Set(cacheKey, companyInfo, _cacheExpiration);
                        _logger.LogDebug($"Loaded and cached: {companyInfo.EntityName}");
                        if(!_cacheKeys.Any(key => key.CacheKey == cacheKey))
                            _cacheKeys.Add(new CompanyFilters(companyInfo.EntityName, cik, cacheKey));
                    }
                    catch(Exception)
                    {
                        throw;
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
