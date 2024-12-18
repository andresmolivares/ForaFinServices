using ForaFinServices.Extensions;
using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;

namespace ForaFinServices.Services
{
    public class FundableAmountService : IFundableAmountService
    {
        private readonly string Cik_FilePath = "CIKs.csv";
        private readonly ICompanyInfoCacheService _companyInfoCacheService;
        private readonly ICikRepositoryService _cikRepositoryService;
        private readonly ILogger<FundableAmountService> _logger;
        private readonly ParallelOptions _parallelOptions;
        private readonly BatchSettings _batchSettings;

        public FundableAmountService(
            ILogger<FundableAmountService> logger, 
            ICompanyInfoCacheService companyInfoCacheService, 
            ICikRepositoryService cikRepositoryService,
            ParallelSettings parallelSettings,
            BatchSettings batchSettings)
        {
            _companyInfoCacheService = companyInfoCacheService;
            _cikRepositoryService = cikRepositoryService;
            _logger = logger;
            _batchSettings = batchSettings;
            _parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = parallelSettings.MaxDegreeOfParallelism };
        }

        public async Task PersistData()
        {
            try
            {
                var ids = await _cikRepositoryService.GetCikIds(Cik_FilePath);
                _logger.LogDebug("Ids loaded.");

                var watch = System.Diagnostics.Stopwatch.StartNew();

                await CacheCompanyInfoData(ids);

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                _logger.LogInformation("CacheCompanyInfoData ran for {0} ms. with a batch Size of {1} and MaxDegreeOfParallelism set to {2}", 
                    elapsedMs,
                    _batchSettings.Size,
                    _parallelOptions.MaxDegreeOfParallelism);
            }
            catch (Exception ex)
            {
                _logger.LogError("SEC Service Initialization Error: {0}", ex.Message);
            }
        }

        private async Task CacheCompanyInfoData(string[] ids)
        {
            var batches = ids.Chunk(_batchSettings.Size);

            foreach (var batch in batches)
            {
                await Parallel.ForEachAsync(batch, _parallelOptions, async (id, cancellationToken) =>
                {
                    try
                    {
                        await _companyInfoCacheService.CacheData(id);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("SEC Service Error for cik Id {0}: {1}", id, ex.Message);
                    }
                });
            }
        }

        public IEnumerable<FundableAmountResponse> GetFundableAmount(string? letterFilter)
        {
            var companyInfos = _companyInfoCacheService.GetCompanyInfo(letterFilter);

            return companyInfos
                .Select(f => f.MapToFundableAmountResponse())
                .OrderBy(f => f.Name);
        }
    }
}
